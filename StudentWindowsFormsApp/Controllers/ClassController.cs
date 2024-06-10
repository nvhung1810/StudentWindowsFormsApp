using StudentWindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Controllers
{
    internal class ClassController
    {
        /* GET ALL */
        public async Task<List<ClassModel>> GetAll()
        {
            List<ClassModel> classList = new List<ClassModel>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [student_management].[dbo].[class]", connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (await reader.ReadAsync())
                    {
                        ClassModel classItem = new ClassModel
                        {
                            IdClass = reader.GetInt32(0),
                            Name = reader.IsDBNull(1) ? "-" : reader.GetString(1),
                            Quantity = reader.IsDBNull(2) ? -1 : reader.GetInt32(2),
                            IdFaculty = reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                        };

                        classList.Add(classItem);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching data: {ex.Message}");
                }
            }

            return classList;
        }
        /* ADD */
        public async Task<bool> AddClass(ClassModel classModel)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        "INSERT INTO [student_management].[dbo].[class] " +
                        "(name, quantity, id_faculty) " +
                        "VALUES (@Name, @Quantity, @IdFaculty)",
                        connection);

                    sqlCommand.Parameters.AddWithValue("@Name", classModel.Name);
                    sqlCommand.Parameters.AddWithValue("@Quantity", classModel.Quantity);
                    sqlCommand.Parameters.AddWithValue("@IdFaculty", classModel.IdFaculty);

                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding class: {ex.Message}");
                    return false;
                }
            }
        }
        /* DELETE */
        public async Task<bool> DeleteClass(int id)
        {
            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = "DELETE FROM [student_management].[dbo].[class] WHERE id_class = @IdClass";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, conn);
                    sqlCommand.Parameters.AddWithValue("@IdClass", id);
                    await sqlCommand.ExecuteNonQueryAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    return false;
                }
            }
        }
        /* UPDATE */
        public async Task<bool> UpdateClass(ClassModel classModel)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = @"
                        UPDATE [student_management].[dbo].[class]
                        SET 
                            name = @Name,
                            quantity = @Quantity,
                            id_faculty = @IdFaculty
                        WHERE id_class = @IdClass";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, connection);

                    sqlCommand.Parameters.AddWithValue("@Name", classModel.Name);
                    sqlCommand.Parameters.AddWithValue("@Quantity", classModel.Quantity);
                    sqlCommand.Parameters.AddWithValue("@IdClass", classModel.IdClass);
                    sqlCommand.Parameters.AddWithValue("@IdFaculty", classModel.IdFaculty);
                    
                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating class: {ex.Message}");
                    return false;
                }
            }
        }
        /* SEARCH */
        public async Task<List<ClassModel>> SearchClass(string name)
        {
            List<ClassModel> classList = new List<ClassModel>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        "SELECT * FROM [student_management].[dbo].[class] WHERE name LIKE @Name",
                        connection);

                    sqlCommand.Parameters.AddWithValue("@Name", $"%{name}%");
                    SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        ClassModel classItem = new ClassModel
                        {
                            IdClass = reader.GetInt32(0),
                            Name = reader.IsDBNull(1) ? "-" : reader.GetString(1),
                            Quantity = reader.IsDBNull(2) ? -1 : reader.GetInt32(2),
                            IdFaculty = reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                        };

                        classList.Add(classItem);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error searching students: {ex.Message}");
                }
            }

            return classList;
        }
    }
}
