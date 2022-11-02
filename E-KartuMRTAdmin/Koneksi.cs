﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KartuMRTAdmin
{
    class Koneksi
    {
        static MySqlConnection conn = new MySqlConnection();
        public static string dbname = "e_kartu_mrt";
        public static string username = "root";
        public static string password = "";
        public static string server = "localhost";

        public static void openConn()
        {
            conn.ConnectionString = string.Format("server={0}; user id={1}; password={2}; database={3}", server, username, password, dbname);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static MySqlConnection getConn()
        {
            return conn;
        }
    }
}
