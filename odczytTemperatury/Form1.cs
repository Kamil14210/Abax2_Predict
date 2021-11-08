using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Data.SQLite;
//using System.Net;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json;
//using System.Web.Script.Serialization;
//using System.Diagnostics;
using System.Threading;

namespace odczytTemperatury
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public class Current
        {
            public float temp_c { get; set; }
        }

        // Strumien sieciowy, ktory zostanie uzyty do komunikacji
        private static NetworkStream myStream;
        // Klient TCP/IP
        private static TcpClient myClient;
        // Bufor odczytu danych
        private static byte[] myBuffer;

        public static bool flaga = false;
        bool button1WasClicked = false;
        private bool programWasStarted = false;
        byte[] mojbajt = { 0xfe, 0xfe, 0x7d, 0x09, 0x4f, 0x98, 0xfe, 0x0d };
        // 7d - command for temperature 

        //FEFE7DA10098FE0D - 21 st.
        public string AdressIP = "10.68.0.100";
        public int Port = 8105;
        public byte Wejscie = 161;
        //do crc
        ushort crc_base = 0x0000147a;
        ushort crc_high16 = 0x0000;
        ushort crc_low16 = 0x0000;
        byte crc_high = 0x00;
        byte crc_low = 0x00;


        int[] tablica_temp = new int[10];
        string wartoscX_z_dataGrid_s1;
        string wartoscY_z_dataGrid_s1;
        string wartoscX_z_dataGrid_s2;
        string wartoscY_z_dataGrid_s2;
        //string wartoscX_z_dataGrid_s3;
        //string wartoscY_z_dataGrid_s3;
        string pomocnicza_do_wartosci_predykowanej;
        string globalTemp = "24.5";
        string[] global_read_predict_temp = new string[1];


        //##Do SQLlite:
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        //string api_temp_c = "";
        SaveToFile zapis_do_pliku = new SaveToFile();
        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=DemoDB.db;Version=3;New=False;Compress=True;");
        }

        //set executequery

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        void readPredTemp()
        {

            StreamReader sr = new StreamReader(@"output.txt");
                globalTemp = sr.ReadLine();
                //globalTemp = global_read_predict_temp.ToString();
                //globalTemp.ToString();
                Console.WriteLine(globalTemp);
            //}
        }

        public Form1()
        {
            InitializeComponent();
            readPredTemp();
            chart1.ChartAreas[0].AxisY.Interval = 2; // to też jest spoko tylko pełen zakres 10-30 st celsjusza
            chart1.ChartAreas[0].AxisX.Interval = 5;
            chart1.Series.Clear();
            LoadData();
            //dataGridView1.DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Wartosc"].DefaultCellStyle.Format = "N1";//0.00##
            dataGridView1.Columns["Wartosc_Pred"].DefaultCellStyle.Format = "N1";//0.00##
            ReadData();

            }
        class Data
        {
            public string Pelna_Data { get; set; }
            public int Czas { get; set; }
            public double Wartosc { get; set; }
            public int Czas_Pred { get; set; }
            public double Wartosc_Pred { get; set; }
        }
        private void LoadData()
        {

            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Temperatura";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            
            DT = DS.Tables[0];
            //DT = DT.Replace(",", ".");
            //DT.ToString(); - to raczej nie 
            dataGridView1.DataSource = DT;
            
            sql_con.Close();

        }
       

        private void mbtn_polacz_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
                AdressIP = mtxb_adresIP.Text;
                Port = Convert.ToInt16(mtxb_port.Text);
                Wejscie = Convert.ToByte(mtxb_nr_wejscia.Text);
                mojbajt[3] = Wejscie;
                myClient = new TcpClient(AdressIP, Port);

                // Zapamietanie strumienia danych sieciowych dla watkow, ktore zostana stworzone
                myStream = myClient.GetStream();
                programWasStarted = true;
                // Stworzenie bufora na dane w pamieci. Bufor powinien miec wielkosc
                // maksymalnej wielkosci jednorazowo pobranych danych z sieci
                myBuffer = new byte[myClient.ReceiveBufferSize];
                //System.Threading.Thread.Sleep(500);
                flaga = true;


            }
            catch
            {
                exitConnection();
                MessageBox.Show("Nie udało się połączyć");
                
            }

        }
         void ReadData()
        {

             var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Temperatura aktualna",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline
            };
             
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                wartoscY_z_dataGrid_s1 = dataGridView1.Rows[i].Cells[2].Value.ToString().Replace(",",".");
                wartoscX_z_dataGrid_s1 = dataGridView1.Rows[i].Cells[1].Value.ToString().Replace(",", ".");

               // wartoscY_z_dataGrid_s2 = dataGridView1.Rows[i].Cells[4].Value.ToString().Replace(",", ".");
               // wartoscX_z_dataGrid_s2 = dataGridView1.Rows[i].Cells[3].Value.ToString().Replace(",", ".");
                series1.Points.AddXY(wartoscX_z_dataGrid_s1, wartoscY_z_dataGrid_s1);
                //series2.Points.AddXY(wartoscX_z_dataGrid_s2, wartoscY_z_dataGrid_s2);
            }
            
           // this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series1);
        }


        void exitConnection()
        {
            try
            {
                button1WasClicked = true;
                if (programWasStarted == true)
                {
                    myClient.Close();
                }
                flaga = false;
                mlbl_status.Text = "Rozłączono";
                //label_wskazania_temp.Text = "-";
                timer1.Enabled = false;
            }
            catch
            {
                flaga = false;
                mlbl_status.Text = "Rozłączono";
            }
        }
        private void mbtn_rozlacz_Click(object sender, EventArgs e)
        {
            exitConnection();

        }

        private void mbtn_domyslne_Click(object sender, EventArgs e)
        {
            mtxb_adresIP.Text = "127.0.0.1"; // "127.0.0.1";"10.68.0.100"
            mtxb_port.Text = "8105";
            mtxb_nr_wejscia.Text = "161";
            mtxb_email.Text = "mail@interia.pl";
            //???????????????????????????AdressIP = textBox_ip.Text;
        }

        private void mbtn_wyslij_mail_Click(object sender, EventArgs e)
        {
            try {
                try
                {

                    string odbiorca = mtxb_email.Text.Trim(); // trim odbicna spacje po obu stronach
                    string temperaturaMail = "Temperatura wskazywana przez czujkę wynosi: " + label_wskazania_temp.Text + "°C";
                    SendMail wysylanie = new SendMail();
                    wysylanie.Send_Mail(temperaturaMail, odbiorca, "Temperatura czujki ABAX2");
                }

                catch
                {
                    MessageBox.Show("Nie udało się wysłać wiadomości. Sprawdź adres e-mail.");
                }
                MessageBox.Show("Wiadomość email została wysłana");
            }
            catch
            {
                MessageBox.Show("Nie udało się wysłać wiadomości. Sprawdź adres e-mail.");
            }
        }

        private void mbtn_zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                AdressIP = mtxb_adresIP.Text;
                Port = Convert.ToInt16(mtxb_port.Text);
                Wejscie = Convert.ToByte(mtxb_nr_wejscia.Text);
                mojbajt[3] = Wejscie;
            }
            catch
            {

                if (mtxb_adresIP.Text == "" || mtxb_port.Text == "" || mtxb_nr_wejscia.Text == "")
                {
                    MessageBox.Show("Proszę wprowadzić odpowiednie dane lub skorzystać z przycisku domyślne.");
                }
            }

        }

        private void mbtn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (flaga == true)
            {

                crc_base = 0x0000147a;
                crc_high16 = 0x0000;
                crc_low16 = 0x0000;
                crc_high = 0x00;
                crc_low = 0x00;

                //Calculate CRC base
                for (int k = 2; k <= 3; k++)
                {
                    /*First step - rotate 1 bit left*/
                    crc_base = (ushort)((crc_base >> 15) | (crc_base << 1));
                    /*Second step - crc xor 0xffff*/
                    crc_base ^= 0xFFFF;
                    crc_base &= 0xFFFF;
                    //get high part of crc
                    crc_high16 = crc_base;
                    crc_high16 >>= 8;
                    crc_high16 &= 0x00FF;
                    crc_high = (byte)crc_high16;
                    /*Final step*/
                    crc_base = (ushort)(crc_high + mojbajt[k] + crc_base);
                }

                //CRC DONE !
                /*Get high and low part of crc_base and put it into the array*/
                //high

                byte[] crc_frame = { 0, 0 };

                crc_high16 = crc_base;
                crc_high16 >>= 8;
                crc_high16 &= 0x00FF;
                crc_high = (byte)crc_high16;

                crc_frame[0] = (byte)crc_high;
                mojbajt[4] = crc_frame[0];

                //low
                crc_low16 = crc_base;
                crc_low16 &= 0x00FF;
                crc_low = (byte)crc_low16;
                crc_frame[1] = (byte)crc_low;
                mojbajt[5] = crc_frame[1];

                myStream.Write(mojbajt, 0, mojbajt.Length);
                // Receive the TcpServer.response.
                // String to store the response ASCII representation.
                // Buffer to store the response bytes.
                byte[] data = new Byte[10];
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                try
                {
                    Int32 bytes = myStream.Read(data, 0, data.Length);
                    double tmp_temp = data[5];
                    double wynik = (double)((tmp_temp - 110) / 2);
                    string tmp_temp2 = wynik.ToString();
                    //:/
                    if (tmp_temp2 == "-31" | tmp_temp2 == "-30" | tmp_temp2 == "-29" | tmp_temp2 == "59" | tmp_temp2 == "61,5" | tmp_temp2 == "-48,5" | tmp_temp2 == "72" | tmp_temp2 == "-72" | tmp_temp2 == "48,5" | tmp_temp2 == "-61,5")
                    {
                        tmp_temp2 = "21.5";
                    }
                    label_wskazania_temp.Text = tmp_temp2 + "°C";
                    if (label_wskazania_temp.Text != "_")
                    {
                        mlbl_status.Text = "Połączono";
                        //return;
                    }

                    try
                    {
                        string pelna_data = DateTime.Now.ToString();
                        string aktualny_czas = DateTime.Now.ToShortTimeString();
                        string predykowany_czas = DateTime.Now.AddMinutes(5).ToShortTimeString();
                        pomocnicza_do_wartosci_predykowanej = label_wskazania_temp.Text.ToString();
                        if (pomocnicza_do_wartosci_predykowanej == "_" | pomocnicza_do_wartosci_predykowanej == "0" | pomocnicza_do_wartosci_predykowanej == "" | pomocnicza_do_wartosci_predykowanej == null)
                        {
                            
                                pomocnicza_do_wartosci_predykowanej = "24.5";
                            
                        }
                        string txtQuery = "INSERT INTO Temperatura (Pelna_Data, Czas, Wartosc, Czas_Pred, Wartosc_Pred) VALUES ('" + pelna_data + "','" + aktualny_czas + "','" + label_wskazania_temp.Text.Trim(new Char[] { ' ', '°', 'C' }) + "','" + predykowany_czas + "','" + globalTemp + "')";//pomocnicza_do_wartosci_predykowanej.Trim(new Char[] { ' ', '°', 'C' })
                        ExecuteQuery(txtQuery);
                        //System.Threading.Thread.Sleep(5000);
                        //sqlite_metoda.LoadData();

                        //#######
                        string[] array_read_predict_temp4 = new string[90];//tablica o rozmiarze 15, bo predykcja na 5 minut czyli 15 pomiarów
                        string[] array_read_predict_temp1 = new string[90];
                        //int[] array_read_predict_temp2 = new int[89];
                        //string line = "24";
                        StreamReader sr = new StreamReader(@"input.txt");
                        //line = sr.ReadLine();
                        for (int i = 0; i <= array_read_predict_temp4.Length - 1; i++)
                        {
                            array_read_predict_temp4[i] = sr.ReadLine();
                            if (array_read_predict_temp4[i] == null)
                            {
                                break;

                            }
                            Console.WriteLine(array_read_predict_temp4[i]);
                            // int j = 0;

                            //j = j + 1;
                        }
                        sr.Close();
                        //Console.WriteLine("#####");

                        for (int i = 1; i < array_read_predict_temp4.Length; i++)//i < array_read_predict_temp4.Length;
                        {
                            array_read_predict_temp1[i - 1] = array_read_predict_temp4[i];
                        }
                        array_read_predict_temp1[89] = label_wskazania_temp.Text.Trim(new Char[] { ' ', '°', 'C' }).Replace(",", ".");

                        System.IO.File.WriteAllBytes(@"input.txt", new byte[0]);

                        for (int i = 0; i < array_read_predict_temp1.Length; i++)
                        {
                            zapis_do_pliku.Saver_(array_read_predict_temp1[i]);

                        }

                        LoadData();
                        dataGridView1.DataSource = DT;
                        LoadData();
                        //dataGridView1.DataSource = sqlite_metoda.getDT();

                    }
                    catch
                    {
                        exitConnection();
                        MessageBox.Show("Nie udało się dodać wpisu do bazy danych. Skontaktuj się z administratorem.");
                        
                    }
                }

                catch
                {
                    flaga = false;
                    exitConnection();
                    mlbl_status.Text = "Utracono połączenie z serwerem";
                }
                // FEFE7DA100A140E4FE0D  - ramka od serwera 25,5 stC

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //JavaScriptSerializer serializer;

        private void SetFocus(object textBox1)
        {
            throw new NotImplementedException();
        }
        public class api_class
        {
            public Current current { get; set; }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        void wykres_predykcja()
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Temp. aktualna",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Point
            };
            var series3 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Temp. predykowana",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line

            };
            //this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series3);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                wartoscY_z_dataGrid_s1 = dataGridView1.Rows[i].Cells[3].Value.ToString().Replace(",", "."); ;
                wartoscX_z_dataGrid_s1 = dataGridView1.Rows[i].Cells[1].Value.ToString().Replace(",", "."); ;
                wartoscY_z_dataGrid_s2 = dataGridView1.Rows[i].Cells[4].Value.ToString().Replace(",", "."); ;
                wartoscX_z_dataGrid_s2 = dataGridView1.Rows[i].Cells[2].Value.ToString().Replace(",", "."); ;

               // series1.Points.AddXY(wartoscX_z_dataGrid_s1, wartoscY_z_dataGrid_s1);
                series3.Points.AddXY(wartoscX_z_dataGrid_s2, wartoscY_z_dataGrid_s2);

            }
        }
        */
        private void mbtn_do_prediction_Click(object sender, EventArgs e)
        {
            exitConnection();
            try
            {
                System.Diagnostics.Process.Start(@"Run_Script.bat");
                //IronPython not work
            }
            catch
            {
                MessageBox.Show("Nie udało się wykonać skryptu Python");

            }
           // int stopwatch = Stopwatch.StartNew();
            Thread.Sleep(5000);
            //stopwatch.Stop();
            string[] array_read_predict_temp = new string [15];//tablica o rozmiarze 15, bo predykcja na 5 minut czyli 15 pomiarów
            string line = "24";
            StreamReader sr = new StreamReader(@"output.txt");
            //line = sr.ReadLine();
            for (int i =0; i< array_read_predict_temp.Length; i++ )
            {
                array_read_predict_temp[i] = sr.ReadLine();
            }
            //array = sr.ReadLine();
            for (int i = 0;  i< array_read_predict_temp.Length; i++)//(line != null || line == "0")
            {
                if (line == null)
                { break; }
                //Read the next line
                // line = sr.ReadLine();
                line = array_read_predict_temp[i];
                string pelna_data = DateTime.Now.ToString();
                string aktualny_czas = DateTime.Now.ToShortTimeString();
                string predykowany_czas = DateTime.Now.AddMinutes(5).ToShortTimeString();
                string pusta_wartosc = label_wskazania_temp.Text.ToString();
                if (pusta_wartosc == "_" | pusta_wartosc == "0" | pusta_wartosc == "" | pusta_wartosc== null)
                {
                    pusta_wartosc = "24.5";
                }
                Console.WriteLine(line);
                string txtQuery = "INSERT INTO Temperatura (Pelna_Data, Czas, Wartosc, Czas_Pred, Wartosc_Pred) VALUES ('" + pelna_data + "','" + aktualny_czas + "','" + pusta_wartosc.Trim(new Char[] { ' ', '°', 'C' }) + "','" + predykowany_czas + "','" + line.Trim(new Char[] { ' ', '°', 'C' }) + "')";//string txtQuery = "INSERT INTO Temperatura (Pelna_Data, Czas, Wartosc, Czas_Pred, Wartosc_Pred) VALUES ('" + pelna_data + "','" + aktualny_czas + "','" + label_wskazania_temp.Text.Trim(new Char[] { ' ', '°', 'C' }) + "','" + predykowany_czas + "','" + pomocnicza_do_wartosci_predykowanej + "')";
                //sqlite_metoda.ExecuteQuery(txtQuery);
                ExecuteQuery(txtQuery);
            }
        }

        private void mbt1_test_do_usuniecia_zapis_do_pliku_Click(object sender, EventArgs e)
        {
            zapis_do_pliku.Saver_(label_wskazania_temp.Text);
        }

        private void mbtn_refresh_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = DT;
            LoadData();
            //wykres_predykcja();
            //ReadDatawykres(1,1);
        }

        private void mbShowOtherSeries_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Interval = 2; // to też jest spoko tylko pełen zakres 10-30 st celsjusza
            chart1.ChartAreas[0].AxisX.Interval = 5;
            chart1.Series.Clear();
            LoadData();
            //dataGridView1.DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Wartosc"].DefaultCellStyle.Format = "N1";//0.00##
            dataGridView1.Columns["Wartosc_Pred"].DefaultCellStyle.Format = "N1";//0.00##
            //ReadData();

            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Temperatura predykowana",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline

            };


            //dataGridView1.Rows[0].Cells[0].Value = "30.08.2021";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               
                wartoscY_z_dataGrid_s2 = dataGridView1.Rows[i].Cells[4].Value.ToString().Replace(",", ".");
                wartoscX_z_dataGrid_s2 = dataGridView1.Rows[i].Cells[3].Value.ToString().Replace(",", ".");
                
                series2.Points.AddXY(wartoscX_z_dataGrid_s2, wartoscY_z_dataGrid_s2);
            }

            this.chart1.Series.Add(series2);
            
        }

        private void mbShowBasicSeries_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Interval = 2; // to też jest spoko tylko pełen zakres 10-30 st celsjusza
            chart1.ChartAreas[0].AxisX.Interval = 5;
            chart1.Series.Clear();
            LoadData();
            //dataGridView1.DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Wartosc"].DefaultCellStyle.Format = "N1";//0.00##
            dataGridView1.Columns["Wartosc_Pred"].DefaultCellStyle.Format = "N1";//0.00##
            //ReadData();

            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Temperatura aktualna",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline
            };

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                wartoscY_z_dataGrid_s1 = dataGridView1.Rows[i].Cells[2].Value.ToString().Replace(",", ".");
                wartoscX_z_dataGrid_s1 = dataGridView1.Rows[i].Cells[1].Value.ToString().Replace(",", ".");
                series1.Points.AddXY(wartoscX_z_dataGrid_s1, wartoscY_z_dataGrid_s1);

            }


            this.chart1.Series.Add(series1);
        }

        private void metroButton1Save_Click(object sender, EventArgs e)
        {
            string[] array_read_predict_temp4 = new string[90];//tablica o rozmiarze 15, bo predykcja na 5 minut czyli 15 pomiarów
            string[] array_read_predict_temp1 = new string[90];
            int[] array_read_predict_temp2 = new int[89];
            string line = "24";
            StreamReader sr = new StreamReader(@"input.txt");
            //line = sr.ReadLine();
            for (int i = 0; i <= array_read_predict_temp4.Length-1; i++)
            {
                array_read_predict_temp4[i] = sr.ReadLine();
                if (array_read_predict_temp4[i] == null)
                {
                    break;

                }
                Console.WriteLine(array_read_predict_temp4[i]);
                // int j = 0;

                //j = j + 1;
            }
            sr.Close();
            Console.WriteLine("#####");
            
            for (int i = 1; i < array_read_predict_temp4.Length; i++)//i < array_read_predict_temp4.Length;
            {
                array_read_predict_temp1[i - 1] = array_read_predict_temp4[i];
            }
            array_read_predict_temp1[89] = "nadpisane";

            
            for (int i = 0; i < array_read_predict_temp1.Length; i++)
            {
                Console.WriteLine(array_read_predict_temp1[i]);

            }
            Console.WriteLine("@@@");
            System.IO.File.WriteAllBytes(@"input.txt", new byte[0]);

            for (int i = 0; i < array_read_predict_temp1.Length; i++)
            {

                Console.WriteLine(array_read_predict_temp1[i]);
                zapis_do_pliku.Saver_(array_read_predict_temp1[i]);
              
            }
            //zapis_do_pliku.Saver_.Close();

            //zapis_do_pliku.Saver_(array_read_predict_temp1);
            //zapis_do_pliku.Saver_(label_wskazania_temp.Text.Trim(new Char[] { ' ', '°', 'C' }));
        }

        private void mbtn_add_Click(object sender, EventArgs e)
        {
            label_wskazania_temp.Text = "21";
        }
    }
}
