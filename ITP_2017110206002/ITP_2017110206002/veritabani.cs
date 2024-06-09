using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ITP_2017110206002
{
    public class veritabani
    {
        MySqlConnection MySqlConnect;
        MySqlDataAdapter MySqlAdapter;
        MySqlCommand MySqlCmd;
        DataTable dt;
        string StrMySqlConnection = "datasource=localhost;uid=Bilal;pwd=Bilal;database=internetbasedprogramming;";
        private MySqlConnection Mysql()
        {
            if (MySqlConnect == null)
                MySqlConnect = new MySqlConnection();
            MySqlConnect.ConnectionString = StrMySqlConnection;
            return MySqlConnect;
        }
        public bool CRUD(string sql)
        {
            try
            {
                if (MySqlConnect == null)
                    MySqlConnect = new MySqlConnection();
                MySqlConnect.ConnectionString = StrMySqlConnection;
                MySqlConnect.Open();
                MySqlCmd = new MySqlCommand(sql, MySqlConnect);
                MySqlCmd.ExecuteNonQuery();
                MySqlConnect.Close();
                MySqlConnect.Dispose();
                MySqlCmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public DataTable DtGetir(string sql)
        {
            MySqlAdapter = new MySqlDataAdapter(sql, StrMySqlConnection);
            dt = new DataTable();
            MySqlAdapter.Fill(dt);
            MySqlAdapter.Dispose();
            return dt;
        }
        public int LastInsert(string sql)
        {
            if (MySqlConnect == null)
                MySqlConnect = new MySqlConnection();
            if(MySqlConnect.State!=ConnectionState.Open)
            {
                MySqlConnect.ConnectionString = StrMySqlConnection;
                MySqlConnect.Open();
            }            

            MySqlAdapter = new MySqlDataAdapter(sql, MySqlConnect);
            dt = new DataTable();
            MySqlAdapter.Fill(dt);
            MySqlAdapter.Dispose();
            MySqlConnect.Close();
            MySqlConnect.Dispose();
            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0][0]);
            else
                return 0;
        }
        
    }
}