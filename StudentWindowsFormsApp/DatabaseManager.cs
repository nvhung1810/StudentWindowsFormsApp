using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    internal class DatabaseManager
    {
        private static string connectionString = "Data Source=DESKTOP-7SO6SP8\\SQLEXPRESS;Initial Catalog=student_management;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
