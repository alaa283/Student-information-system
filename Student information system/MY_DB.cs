using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_information_system
{
    class MY_DB
    {
        //connection
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_student_db");

        // function to get connection
        public MySqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        //function to open connection
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //function to close connection
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
