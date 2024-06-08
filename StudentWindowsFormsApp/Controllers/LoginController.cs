using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Controllers
{
    internal class LoginController
    {
        public bool Login(string email, string password)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [student_management].[dbo].[user] WHERE email = @Email AND password = @Password", connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }

                reader.Close();
            }

            return false;
        }
    }
}
