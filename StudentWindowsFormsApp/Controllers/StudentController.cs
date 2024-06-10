using StudentWindowsFormsApp.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Controllers
{
    internal class StudentController
    {
        /* GET ALL */
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
                            IdStudent = reader.GetInt32(0),
                            FullName = reader.IsDBNull(1) ? "-" : reader.GetString(1),
                            DateOfBirth = reader.IsDBNull(2) ? "-" : reader.GetString(2),
                            Gender = reader.IsDBNull(3) ? "-" : reader.GetString(3),
                            Address = reader.IsDBNull(4) ? "-" : reader.GetString(4),
                            Class = reader.IsDBNull(5) ? "-" : reader.GetString(5),
                            Gpa = reader.IsDBNull(6) ? -1 : reader.GetInt32(6),
                            Phone = reader.IsDBNull(7) ? -1 : reader.GetInt32(7),
                            Email = reader.IsDBNull(8) ? "-" : reader.GetString(8),
                            IdFaculty = reader.IsDBNull(9) ? -1 : reader.GetInt32(9),
                            IdClass = reader.IsDBNull(10) ? -1 : reader.GetInt32(10),
                        };

                        students.Add(student);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching data: {ex.Message}");
                }
            }

            return students;
        }
        /* ADD */
        public async Task<bool> AddStudentAsync(Student student)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        "INSERT INTO [student_management].[dbo].[students] " +
                        "(full_name, date_of_birth, gender, address, class, gpa, phone, email, id_class, id_faculty) " +
                        "VALUES (@FullName, @DateOfBirth, @Gender, @Address, @Class, @Gpa, @Phone, @Email, @IdClass, @IdFaculty)",
                        connection);

                    sqlCommand.Parameters.AddWithValue("@FullName", student.FullName);
                    sqlCommand.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    sqlCommand.Parameters.AddWithValue("@Gender", student.Gender);
                    sqlCommand.Parameters.AddWithValue("@Address", student.Address);
                    sqlCommand.Parameters.AddWithValue("@Class", student.Class);
                    sqlCommand.Parameters.AddWithValue("@Gpa", student.Gpa);
                    sqlCommand.Parameters.AddWithValue("@Phone", student.Phone);
                    sqlCommand.Parameters.AddWithValue("@Email", student.Email);
                    sqlCommand.Parameters.AddWithValue("@IdClass", student.IdClass);
                    sqlCommand.Parameters.AddWithValue("@IdFaculty", student.IdFaculty);

                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding student: {ex.Message}");
                    return false;
                }
            }
        }
        /* DELETE */
        public async Task<bool> DeleteStudentAsync(int id)
        {
            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = "DELETE FROM [student_management].[dbo].[students] WHERE id_student = @IdStudent";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, conn);
                    sqlCommand.Parameters.AddWithValue("@IdStudent", id);
                    await sqlCommand.ExecuteNonQueryAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        /* UPDATE */
        public async Task<bool> UpdateStudentAsync(Student student)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = @"
                        UPDATE [student_management].[dbo].[students]
                        SET 
                            [full_name] = @FullName,
                            [date_of_birth] = @DateOfBirth,
                            [gender] = @Gender,
                            [address] = @Address,
                            [class] = @Class,
                            [gpa] = @Gpa,
                            [phone] = @Phone,
                            [email] = @Email,
                            [id_faculty] = @IdFaculty,
                            [id_class] = @IdClass
                        WHERE id_student = @IdStudent";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, connection);

                    Console.WriteLine(student.IdStudent);


                    sqlCommand.Parameters.AddWithValue("@FullName", student.FullName);
                    sqlCommand.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    sqlCommand.Parameters.AddWithValue("@Gender", student.Gender);
                    sqlCommand.Parameters.AddWithValue("@Address", student.Address);
                    sqlCommand.Parameters.AddWithValue("@Class", student.Class);
                    sqlCommand.Parameters.AddWithValue("@Gpa", student.Gpa);
                    sqlCommand.Parameters.AddWithValue("@Phone", student.Phone);
                    sqlCommand.Parameters.AddWithValue("@Email", student.Email);
                    sqlCommand.Parameters.AddWithValue("@IdClass", student.IdClass);
                    sqlCommand.Parameters.AddWithValue("@IdFaculty", student.IdFaculty);
                    sqlCommand.Parameters.AddWithValue("@IdStudent", student.IdStudent);

                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating student: {ex.Message}");
                    return false;
                }
            }
        }
        /* SEARCH */
        public async Task<List<Student>> SearchStudentsByFullNameAsync(string fullName)
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        "SELECT * FROM [student_management].[dbo].[students] WHERE full_name LIKE @FullName",
                        connection);

                    sqlCommand.Parameters.AddWithValue("@FullName", $"%{fullName}%");
                    SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        Student student = new Student
                        {
                            IdStudent = reader.GetInt32(0),
                            FullName = reader.IsDBNull(1) ? "-" : reader.GetString(1),
                            DateOfBirth = reader.IsDBNull(2) ? "-" : reader.GetString(2),
                            Gender = reader.IsDBNull(3) ? "-" : reader.GetString(3),
                            Address = reader.IsDBNull(4) ? "-" : reader.GetString(4),
                            Class = reader.IsDBNull(5) ? "-" : reader.GetString(5),
                            Gpa = reader.IsDBNull(6) ? -1 : reader.GetInt32(6),
                            Phone = reader.IsDBNull(7) ? -1 : reader.GetInt32(7),
                            Email = reader.IsDBNull(8) ? "-" : reader.GetString(8),
                            IdFaculty = reader.IsDBNull(9) ? -1 : reader.GetInt32(9),
                            IdClass = reader.IsDBNull(10) ? -1 : reader.GetInt32(10),
                        };

                        students.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error searching students: {ex.Message}");
                }
            }

            return students;
        }
    }
}
