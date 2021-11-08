using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace odczytTemperatury
{
    class SQLite
    {
        
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public DataTable getDT()
        {
            if (DT != null)
            {
                return DT;
            }
            else
            {
                LoadData();
                return DT;
            }
        }

        //set connection
        public void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=DemoDB.db;Version=3;New=False;Compress=True;");
        }
        //set loadDB

        public void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Temperatura";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            //dataGridView1.DataSource = DT;
            sql_con.Close();

        }
        //set executequery
        public void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        
    }
}
