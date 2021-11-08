
namespace odczytTemperatury
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Odczyt_temperatury = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1Save = new MetroFramework.Controls.MetroButton();
            this.mbt1_test_do_usuniecia_zapis_do_pliku = new MetroFramework.Controls.MetroButton();
            this.mbtn_do_prediction = new MetroFramework.Controls.MetroButton();
            this.label_wskazania_temp = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.mbtn_wyslij_mail = new MetroFramework.Controls.MetroButton();
            this.mbtn_rozlacz = new MetroFramework.Controls.MetroButton();
            this.mbtn_polacz = new MetroFramework.Controls.MetroButton();
            this.Konfiguracja_serwera = new MetroFramework.Controls.MetroTabPage();
            this.mbtn_domyslne = new MetroFramework.Controls.MetroButton();
            this.mtxb_email = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_email = new MetroFramework.Controls.MetroLabel();
            this.mbtn_zapisz = new MetroFramework.Controls.MetroButton();
            this.mtxb_nr_wejscia = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_port = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_adresIP = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_nr_wejscia = new MetroFramework.Controls.MetroLabel();
            this.mlbl_port = new MetroFramework.Controls.MetroLabel();
            this.mlbl_adresIP = new MetroFramework.Controls.MetroLabel();
            this.Wykres_zmian_temperatury = new MetroFramework.Controls.MetroTabPage();
            this.mbShowBasicSeries = new MetroFramework.Controls.MetroButton();
            this.mbShowOtherSeries = new MetroFramework.Controls.MetroButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Historia_wskazan = new MetroFramework.Controls.MetroTabPage();
            this.mbtn_refresh = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mlbl_status = new MetroFramework.Controls.MetroLabel();
            this.mbtn_exit = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mbtn_add = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.Odczyt_temperatury.SuspendLayout();
            this.Konfiguracja_serwera.SuspendLayout();
            this.Wykres_zmian_temperatury.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Historia_wskazan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(470, 110);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
            this.metroUserControl1.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Odczyt_temperatury);
            this.metroTabControl1.Controls.Add(this.Konfiguracja_serwera);
            this.metroTabControl1.Controls.Add(this.Wykres_zmian_temperatury);
            this.metroTabControl1.Controls.Add(this.Historia_wskazan);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1196, 550);
            this.metroTabControl1.TabIndex = 1;
            // 
            // Odczyt_temperatury
            // 
            this.Odczyt_temperatury.Controls.Add(this.mbtn_add);
            this.Odczyt_temperatury.Controls.Add(this.metroButton1Save);
            this.Odczyt_temperatury.Controls.Add(this.mbt1_test_do_usuniecia_zapis_do_pliku);
            this.Odczyt_temperatury.Controls.Add(this.mbtn_do_prediction);
            this.Odczyt_temperatury.Controls.Add(this.label_wskazania_temp);
            this.Odczyt_temperatury.Controls.Add(this.metroTextBox1);
            this.Odczyt_temperatury.Controls.Add(this.mbtn_wyslij_mail);
            this.Odczyt_temperatury.Controls.Add(this.mbtn_rozlacz);
            this.Odczyt_temperatury.Controls.Add(this.mbtn_polacz);
            this.Odczyt_temperatury.HorizontalScrollbarBarColor = true;
            this.Odczyt_temperatury.Location = new System.Drawing.Point(4, 35);
            this.Odczyt_temperatury.Name = "Odczyt_temperatury";
            this.Odczyt_temperatury.Size = new System.Drawing.Size(1188, 511);
            this.Odczyt_temperatury.TabIndex = 0;
            this.Odczyt_temperatury.Text = "Odczyt temperatury";
            this.Odczyt_temperatury.VerticalScrollbarBarColor = true;
            // 
            // metroButton1Save
            // 
            this.metroButton1Save.Location = new System.Drawing.Point(28, 308);
            this.metroButton1Save.Name = "metroButton1Save";
            this.metroButton1Save.Size = new System.Drawing.Size(151, 58);
            this.metroButton1Save.TabIndex = 17;
            this.metroButton1Save.Text = "Nadpisywanie do pliku";
            this.metroButton1Save.Click += new System.EventHandler(this.metroButton1Save_Click);
            // 
            // mbt1_test_do_usuniecia_zapis_do_pliku
            // 
            this.mbt1_test_do_usuniecia_zapis_do_pliku.Location = new System.Drawing.Point(28, 228);
            this.mbt1_test_do_usuniecia_zapis_do_pliku.Name = "mbt1_test_do_usuniecia_zapis_do_pliku";
            this.mbt1_test_do_usuniecia_zapis_do_pliku.Size = new System.Drawing.Size(151, 58);
            this.mbt1_test_do_usuniecia_zapis_do_pliku.TabIndex = 16;
            this.mbt1_test_do_usuniecia_zapis_do_pliku.Text = "Test - zapis do pliku";
            this.mbt1_test_do_usuniecia_zapis_do_pliku.Click += new System.EventHandler(this.mbt1_test_do_usuniecia_zapis_do_pliku_Click);
            // 
            // mbtn_do_prediction
            // 
            this.mbtn_do_prediction.Highlight = true;
            this.mbtn_do_prediction.Location = new System.Drawing.Point(286, 73);
            this.mbtn_do_prediction.Name = "mbtn_do_prediction";
            this.mbtn_do_prediction.Size = new System.Drawing.Size(151, 58);
            this.mbtn_do_prediction.Style = MetroFramework.MetroColorStyle.Blue;
            this.mbtn_do_prediction.TabIndex = 15;
            this.mbtn_do_prediction.Text = "Wykonaj predykcję";
            this.mbtn_do_prediction.Click += new System.EventHandler(this.mbtn_do_prediction_Click);
            // 
            // label_wskazania_temp
            // 
            this.label_wskazania_temp.AutoSize = true;
            this.label_wskazania_temp.BackColor = System.Drawing.Color.White;
            this.label_wskazania_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wskazania_temp.Location = new System.Drawing.Point(38, 15);
            this.label_wskazania_temp.Name = "label_wskazania_temp";
            this.label_wskazania_temp.Size = new System.Drawing.Size(51, 55);
            this.label_wskazania_temp.TabIndex = 13;
            this.label_wskazania_temp.Text = "_";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox1.TabIndex = 14;
            // 
            // mbtn_wyslij_mail
            // 
            this.mbtn_wyslij_mail.Highlight = true;
            this.mbtn_wyslij_mail.Location = new System.Drawing.Point(286, 151);
            this.mbtn_wyslij_mail.Name = "mbtn_wyslij_mail";
            this.mbtn_wyslij_mail.Size = new System.Drawing.Size(151, 58);
            this.mbtn_wyslij_mail.Style = MetroFramework.MetroColorStyle.Blue;
            this.mbtn_wyslij_mail.TabIndex = 6;
            this.mbtn_wyslij_mail.Text = "Wyślij wiadomość email";
            this.mbtn_wyslij_mail.Click += new System.EventHandler(this.mbtn_wyslij_mail_Click);
            // 
            // mbtn_rozlacz
            // 
            this.mbtn_rozlacz.Highlight = true;
            this.mbtn_rozlacz.Location = new System.Drawing.Point(364, 15);
            this.mbtn_rozlacz.Name = "mbtn_rozlacz";
            this.mbtn_rozlacz.Size = new System.Drawing.Size(102, 35);
            this.mbtn_rozlacz.Style = MetroFramework.MetroColorStyle.Red;
            this.mbtn_rozlacz.TabIndex = 5;
            this.mbtn_rozlacz.Text = "Rozłącz";
            this.mbtn_rozlacz.Click += new System.EventHandler(this.mbtn_rozlacz_Click);
            // 
            // mbtn_polacz
            // 
            this.mbtn_polacz.Highlight = true;
            this.mbtn_polacz.Location = new System.Drawing.Point(240, 15);
            this.mbtn_polacz.Name = "mbtn_polacz";
            this.mbtn_polacz.Size = new System.Drawing.Size(105, 35);
            this.mbtn_polacz.Style = MetroFramework.MetroColorStyle.Green;
            this.mbtn_polacz.TabIndex = 4;
            this.mbtn_polacz.Text = "Połącz z serwerem";
            this.mbtn_polacz.Click += new System.EventHandler(this.mbtn_polacz_Click);
            // 
            // Konfiguracja_serwera
            // 
            this.Konfiguracja_serwera.Controls.Add(this.mbtn_domyslne);
            this.Konfiguracja_serwera.Controls.Add(this.mtxb_email);
            this.Konfiguracja_serwera.Controls.Add(this.mlbl_email);
            this.Konfiguracja_serwera.Controls.Add(this.mbtn_zapisz);
            this.Konfiguracja_serwera.Controls.Add(this.mtxb_nr_wejscia);
            this.Konfiguracja_serwera.Controls.Add(this.mtxb_port);
            this.Konfiguracja_serwera.Controls.Add(this.mtxb_adresIP);
            this.Konfiguracja_serwera.Controls.Add(this.mlbl_nr_wejscia);
            this.Konfiguracja_serwera.Controls.Add(this.mlbl_port);
            this.Konfiguracja_serwera.Controls.Add(this.mlbl_adresIP);
            this.Konfiguracja_serwera.HorizontalScrollbarBarColor = true;
            this.Konfiguracja_serwera.Location = new System.Drawing.Point(4, 35);
            this.Konfiguracja_serwera.Name = "Konfiguracja_serwera";
            this.Konfiguracja_serwera.Size = new System.Drawing.Size(1188, 511);
            this.Konfiguracja_serwera.TabIndex = 1;
            this.Konfiguracja_serwera.Text = "Konfiguracja serwera";
            this.Konfiguracja_serwera.VerticalScrollbarBarColor = true;
            // 
            // mbtn_domyslne
            // 
            this.mbtn_domyslne.Highlight = true;
            this.mbtn_domyslne.Location = new System.Drawing.Point(288, 82);
            this.mbtn_domyslne.Name = "mbtn_domyslne";
            this.mbtn_domyslne.Size = new System.Drawing.Size(123, 65);
            this.mbtn_domyslne.Style = MetroFramework.MetroColorStyle.Blue;
            this.mbtn_domyslne.TabIndex = 11;
            this.mbtn_domyslne.Text = "Domyślne/wzorcowe";
            this.mbtn_domyslne.Click += new System.EventHandler(this.mbtn_domyslne_Click);
            // 
            // mtxb_email
            // 
            this.mtxb_email.Location = new System.Drawing.Point(182, 176);
            this.mtxb_email.Name = "mtxb_email";
            this.mtxb_email.Size = new System.Drawing.Size(229, 23);
            this.mtxb_email.TabIndex = 10;
            // 
            // mlbl_email
            // 
            this.mlbl_email.AutoSize = true;
            this.mlbl_email.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbl_email.Location = new System.Drawing.Point(5, 176);
            this.mlbl_email.Name = "mlbl_email";
            this.mlbl_email.Size = new System.Drawing.Size(178, 19);
            this.mlbl_email.TabIndex = 9;
            this.mlbl_email.Text = "Email do powiadamiania:";
            // 
            // mbtn_zapisz
            // 
            this.mbtn_zapisz.Highlight = true;
            this.mbtn_zapisz.Location = new System.Drawing.Point(288, 21);
            this.mbtn_zapisz.Name = "mbtn_zapisz";
            this.mbtn_zapisz.Size = new System.Drawing.Size(123, 55);
            this.mbtn_zapisz.Style = MetroFramework.MetroColorStyle.Blue;
            this.mbtn_zapisz.TabIndex = 8;
            this.mbtn_zapisz.Text = "Zapisz";
            this.mbtn_zapisz.Click += new System.EventHandler(this.mbtn_zapisz_Click);
            // 
            // mtxb_nr_wejscia
            // 
            this.mtxb_nr_wejscia.Location = new System.Drawing.Point(86, 89);
            this.mtxb_nr_wejscia.Name = "mtxb_nr_wejscia";
            this.mtxb_nr_wejscia.Size = new System.Drawing.Size(114, 23);
            this.mtxb_nr_wejscia.TabIndex = 7;
            // 
            // mtxb_port
            // 
            this.mtxb_port.Location = new System.Drawing.Point(86, 57);
            this.mtxb_port.Name = "mtxb_port";
            this.mtxb_port.Size = new System.Drawing.Size(114, 23);
            this.mtxb_port.TabIndex = 6;
            // 
            // mtxb_adresIP
            // 
            this.mtxb_adresIP.Location = new System.Drawing.Point(86, 26);
            this.mtxb_adresIP.Name = "mtxb_adresIP";
            this.mtxb_adresIP.Size = new System.Drawing.Size(114, 23);
            this.mtxb_adresIP.TabIndex = 5;
            // 
            // mlbl_nr_wejscia
            // 
            this.mlbl_nr_wejscia.AutoSize = true;
            this.mlbl_nr_wejscia.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbl_nr_wejscia.Location = new System.Drawing.Point(5, 89);
            this.mlbl_nr_wejscia.Name = "mlbl_nr_wejscia";
            this.mlbl_nr_wejscia.Size = new System.Drawing.Size(82, 19);
            this.mlbl_nr_wejscia.TabIndex = 4;
            this.mlbl_nr_wejscia.Text = "Nr wejścia:";
            // 
            // mlbl_port
            // 
            this.mlbl_port.AutoSize = true;
            this.mlbl_port.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbl_port.Location = new System.Drawing.Point(45, 57);
            this.mlbl_port.Name = "mlbl_port";
            this.mlbl_port.Size = new System.Drawing.Size(42, 19);
            this.mlbl_port.TabIndex = 3;
            this.mlbl_port.Text = "Port:";
            // 
            // mlbl_adresIP
            // 
            this.mlbl_adresIP.AutoSize = true;
            this.mlbl_adresIP.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbl_adresIP.Location = new System.Drawing.Point(18, 26);
            this.mlbl_adresIP.Name = "mlbl_adresIP";
            this.mlbl_adresIP.Size = new System.Drawing.Size(69, 19);
            this.mlbl_adresIP.TabIndex = 2;
            this.mlbl_adresIP.Text = "Adres IP:";
            // 
            // Wykres_zmian_temperatury
            // 
            this.Wykres_zmian_temperatury.Controls.Add(this.mbShowBasicSeries);
            this.Wykres_zmian_temperatury.Controls.Add(this.mbShowOtherSeries);
            this.Wykres_zmian_temperatury.Controls.Add(this.chart1);
            this.Wykres_zmian_temperatury.HorizontalScrollbarBarColor = true;
            this.Wykres_zmian_temperatury.Location = new System.Drawing.Point(4, 35);
            this.Wykres_zmian_temperatury.Name = "Wykres_zmian_temperatury";
            this.Wykres_zmian_temperatury.Size = new System.Drawing.Size(1188, 511);
            this.Wykres_zmian_temperatury.TabIndex = 3;
            this.Wykres_zmian_temperatury.Text = "Wykres zmian temperatury";
            this.Wykres_zmian_temperatury.VerticalScrollbarBarColor = true;
            // 
            // mbShowBasicSeries
            // 
            this.mbShowBasicSeries.Highlight = true;
            this.mbShowBasicSeries.Location = new System.Drawing.Point(992, 363);
            this.mbShowBasicSeries.Name = "mbShowBasicSeries";
            this.mbShowBasicSeries.Size = new System.Drawing.Size(158, 43);
            this.mbShowBasicSeries.Style = MetroFramework.MetroColorStyle.Green;
            this.mbShowBasicSeries.TabIndex = 5;
            this.mbShowBasicSeries.Text = "Bieżący odczyt ";
            this.mbShowBasicSeries.Click += new System.EventHandler(this.mbShowBasicSeries_Click);
            // 
            // mbShowOtherSeries
            // 
            this.mbShowOtherSeries.Highlight = true;
            this.mbShowOtherSeries.Location = new System.Drawing.Point(992, 428);
            this.mbShowOtherSeries.Name = "mbShowOtherSeries";
            this.mbShowOtherSeries.Size = new System.Drawing.Size(158, 45);
            this.mbShowOtherSeries.Style = MetroFramework.MetroColorStyle.Red;
            this.mbShowOtherSeries.TabIndex = 4;
            this.mbShowOtherSeries.Text = "Temperatura predykowana";
            this.mbShowOtherSeries.Click += new System.EventHandler(this.mbShowOtherSeries_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisY.Maximum = 30D;
            chartArea1.AxisY.Minimum = 10D;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea1.AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-50, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=True, LabelStyle=Center";
            series1.Font = new System.Drawing.Font("Times New Roman", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1130, 515);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Historia_wskazan
            // 
            this.Historia_wskazan.Controls.Add(this.mbtn_refresh);
            this.Historia_wskazan.Controls.Add(this.dataGridView1);
            this.Historia_wskazan.HorizontalScrollbarBarColor = true;
            this.Historia_wskazan.Location = new System.Drawing.Point(4, 35);
            this.Historia_wskazan.Name = "Historia_wskazan";
            this.Historia_wskazan.Size = new System.Drawing.Size(1188, 511);
            this.Historia_wskazan.TabIndex = 2;
            this.Historia_wskazan.Text = "Historia wskazań";
            this.Historia_wskazan.VerticalScrollbarBarColor = true;
            // 
            // mbtn_refresh
            // 
            this.mbtn_refresh.Highlight = true;
            this.mbtn_refresh.Location = new System.Drawing.Point(601, 457);
            this.mbtn_refresh.Name = "mbtn_refresh";
            this.mbtn_refresh.Size = new System.Drawing.Size(115, 51);
            this.mbtn_refresh.Style = MetroFramework.MetroColorStyle.Blue;
            this.mbtn_refresh.TabIndex = 4;
            this.mbtn_refresh.Text = "Odśwież";
            this.mbtn_refresh.Click += new System.EventHandler(this.mbtn_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(444, 503);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mlbl_status
            // 
            this.mlbl_status.AutoSize = true;
            this.mlbl_status.Location = new System.Drawing.Point(32, 615);
            this.mlbl_status.Name = "mlbl_status";
            this.mlbl_status.Size = new System.Drawing.Size(15, 19);
            this.mlbl_status.TabIndex = 2;
            this.mlbl_status.Text = "_";
            // 
            // mbtn_exit
            // 
            this.mbtn_exit.Highlight = true;
            this.mbtn_exit.Location = new System.Drawing.Point(1102, 604);
            this.mbtn_exit.Name = "mbtn_exit";
            this.mbtn_exit.Size = new System.Drawing.Size(75, 23);
            this.mbtn_exit.Style = MetroFramework.MetroColorStyle.Blue;
            this.mbtn_exit.TabIndex = 3;
            this.mbtn_exit.Text = "Zakończ";
            this.mbtn_exit.Click += new System.EventHandler(this.mbtn_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mbtn_add
            // 
            this.mbtn_add.Location = new System.Drawing.Point(28, 151);
            this.mbtn_add.Name = "mbtn_add";
            this.mbtn_add.Size = new System.Drawing.Size(151, 58);
            this.mbtn_add.TabIndex = 18;
            this.mbtn_add.Text = "Test - wstaw wartość 21";
            this.mbtn_add.Click += new System.EventHandler(this.mbtn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.mbtn_exit);
            this.Controls.Add(this.mlbl_status);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "Form1";
            this.Text = "ABAX2 Predict";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Odczyt_temperatury.ResumeLayout(false);
            this.Odczyt_temperatury.PerformLayout();
            this.Konfiguracja_serwera.ResumeLayout(false);
            this.Konfiguracja_serwera.PerformLayout();
            this.Wykres_zmian_temperatury.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Historia_wskazan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Odczyt_temperatury;
        private MetroFramework.Controls.MetroTabPage Konfiguracja_serwera;
        private MetroFramework.Controls.MetroButton mbtn_zapisz;
        private MetroFramework.Controls.MetroTextBox mtxb_nr_wejscia;
        private MetroFramework.Controls.MetroTextBox mtxb_port;
        private MetroFramework.Controls.MetroTextBox mtxb_adresIP;
        private MetroFramework.Controls.MetroLabel mlbl_nr_wejscia;
        private MetroFramework.Controls.MetroLabel mlbl_port;
        private MetroFramework.Controls.MetroLabel mlbl_adresIP;
        private MetroFramework.Controls.MetroTextBox mtxb_email;
        private MetroFramework.Controls.MetroLabel mlbl_email;
        private MetroFramework.Controls.MetroButton mbtn_rozlacz;
        private MetroFramework.Controls.MetroButton mbtn_polacz;
        private MetroFramework.Controls.MetroTabPage Historia_wskazan;
        private MetroFramework.Controls.MetroButton mbtn_domyslne;
        private MetroFramework.Controls.MetroLabel mlbl_status;
        private MetroFramework.Controls.MetroButton mbtn_wyslij_mail;
        private MetroFramework.Controls.MetroButton mbtn_exit;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label_wskazania_temp;
        private MetroFramework.Controls.MetroButton mbtn_do_prediction;
        private MetroFramework.Controls.MetroButton mbt1_test_do_usuniecia_zapis_do_pliku;
        private MetroFramework.Controls.MetroButton mbtn_refresh;
        private MetroFramework.Controls.MetroTabPage Wykres_zmian_temperatury;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton mbShowOtherSeries;
        private MetroFramework.Controls.MetroButton mbShowBasicSeries;
        private MetroFramework.Controls.MetroButton metroButton1Save;
        private MetroFramework.Controls.MetroButton mbtn_add;
    }
}

