using StudentWindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Controllers
{
    internal class FacultyController
    {
        /* GET ALL */
        public async Task<List<FacultyModel>> GetAllFaculty()
        {
            List<FacultyModel> facultyList = new List<FacultyModel>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [student_management].[dbo].[faculty]", connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (await reader.ReadAsync())
                    {
                        FacultyModel faculty = new FacultyModel
                        {
                            IdFaculty = reader.GetInt32(0),
                            Name = reader.IsDBNull(1) ? "-" : reader.GetString(1),
                            Phone = reader.IsDBNull(2) ? "-" : reader.GetString(2),
                            Address = reader.IsDBNull(3) ? "-" : reader.GetString(3),
                        };

                        facultyList.Add(faculty);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching data: {ex.Message}");
                }
            }

            return facultyList;
        }
        /* CREATE */
        public async Task<bool> AddFaculty(FacultyModel faculty)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        "INSERT INTO [student_management].[dbo].[faculty] " +
                        "(name, phone, address) " +
                        "VALUES (@Name, @Phone, @Address)",
                        connection);

                    sqlCommand.Parameters.AddWithValue("@Name", faculty.Name);
                    sqlCommand.Parameters.AddWithValue("@Phone", faculty.Phone);
                    sqlCommand.Parameters.AddWithValue("@Address", faculty.Address);

                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding faculty: {ex.Message}");
                    return false;
                }
            }
        }
        /* DELETE*/
        public async Task<bool> DeleteFaculty(int id)
        {
            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = "DELETE FROM [student_management].[dbo].[faculty] WHERE id_faculty = @IdFaculty";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, conn);
                    sqlCommand.Parameters.AddWithValue("@IdFaculty", id);
                    await sqlCommand.ExecuteNonQueryAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching data: {ex.Message}");
                    return false;
                }
            }
        }
        /* UPDATE */
        public async Task<bool> UpdateFaculty(FacultyModel faculty)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = @"
                        UPDATE [student_management].[dbo].[faculty]
                        SET 
                            name = @Name,
                            phone = @Phone,
                            address = @Address
                        WHERE id_faculty = @IdFaculty";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, connection);

                    sqlCommand.Parameters.AddWithValue("@Name", faculty.Name);
                    sqlCommand.Parameters.AddWithValue("@Phone", faculty.Phone);
                    sqlCommand.Parameters.AddWithValue("@Address", faculty.Address);
                    sqlCommand.Parameters.AddWithValue("@IdFaculty", faculty.IdFaculty);

                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating faculty: {ex.Message}");
                    return false;
                }
            }
        }
        /* SEARCH */
        public async Task<List<FacultyModel>> SearchFaculty(string name)
        {
            List<FacultyModel> faculties = new List<FacultyModel>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        "SELECT * FROM [student_management].[dbo].[faculty] WHERE name LIKE @Name",
                        connection);

                    sqlCommand.Parameters.AddWithValue("@Name", $"%{name}%");
                    SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        FacultyModel faculty = new FacultyModel
                        {
                            IdFaculty = reader.GetInt32(0),
                            Name = reader.IsDBNull(1) ? "-" : reader.GetString(1),
                            Phone = reader.IsDBNull(2) ? "-" : reader.GetString(2),
                            Address = reader.IsDBNull(3) ? "-" : reader.GetString(3),
                        };

                        faculties.Add(faculty);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error searching faculty: {ex.Message}");
                }
            }

            return faculties;
        }
    }
}
