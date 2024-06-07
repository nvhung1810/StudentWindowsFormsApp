using StudentWindowsFormsApp.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Controllers
{
    internal class StudentController
    {
        public async Task<List<Student>> GetAllStudentAsync()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                   SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [student_management].[dbo].[students]", connection);
                   SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (await reader.ReadAsync())
                    {
                        Student student = new Student
                        {
                            Id = reader.GetInt32(0),
                            FullName = reader.GetString(1),
                            DateOfBirth = reader.GetString(2),
                            Gender = reader.GetString(3),
                            Address = reader.GetString(4),
                            Class = reader.GetString(5),
                            MathScores = reader.GetInt32(6),
                            EnglishScores = reader.GetInt32(7),
                            Email = reader.GetString(8),
                        };

                        students.Add(student);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching data: {ex.Message}");
                }
            }
            Console.WriteLine($"Total students retrieved: {students.Count}");
            return students;
        }

    }
}
