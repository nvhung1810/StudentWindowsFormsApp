using StudentWindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Controllers
{
    internal class ScoresController
    {
        /* GET ALL */
        public async Task<List<ScoresModel>> GetAll()
        {
            List<ScoresModel> scores = new List<ScoresModel>();

            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [student_management].[dbo].[scores]", connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (await reader.ReadAsync())
                    {
                        ScoresModel scoresModel = new ScoresModel
                        {
                            IdScores = reader.GetInt32(0),
                            Math = reader.IsDBNull(1) ? -1 : reader.GetInt32(1),
                            BasicTechnology = reader.IsDBNull(2) ? -1 : reader.GetInt32(2),
                            Physics = reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                            NetTechnology = reader.IsDBNull(4) ? -1 : reader.GetInt32(4),
                            GeneralLaw = reader.IsDBNull(5) ? -1 : reader.GetInt32(5),
                            English = reader.IsDBNull(6) ? -1 : reader.GetInt32(6),
                            ImageProcessing = reader.IsDBNull(7) ? -1 : reader.GetInt32(7),
                            IdStudent = reader.IsDBNull(7) ? -1 : reader.GetInt32(7),
                        };

                        scores.Add(scoresModel);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching data: {ex.Message}");
                }
            }

            return scores;
        }
        public async Task<bool> AddScore(ScoresModel scoresModel)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        "INSERT INTO [student_management].[dbo].[scores] " +
                        "([math], [basic_technology], [physics], [net_technology], [general_law], [english], [image_processing], [id_student]) " +
                        "VALUES (@Math, @BasicTechnology, @Physics, @NetTechnology, @GeneralLaw, @English, @ImageProcessing, @IdStudent)",
                        connection);

                    sqlCommand.Parameters.AddWithValue("@Math", scoresModel.Math);
                    sqlCommand.Parameters.AddWithValue("@BasicTechnology", scoresModel.BasicTechnology);
                    sqlCommand.Parameters.AddWithValue("@Physics", scoresModel.Physics);
                    sqlCommand.Parameters.AddWithValue("@NetTechnology", scoresModel.NetTechnology);
                    sqlCommand.Parameters.AddWithValue("@GeneralLaw", scoresModel.GeneralLaw);
                    sqlCommand.Parameters.AddWithValue("@English", scoresModel.English);
                    sqlCommand.Parameters.AddWithValue("@ImageProcessing", scoresModel.ImageProcessing);
                    sqlCommand.Parameters.AddWithValue("@IdStudent", scoresModel.IdStudent);

                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding scores: {ex.Message}");
                    return false;
                }
            }
        }
        /* DELETE */
        public async Task<bool> DeleteScore(int id)
        {
            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = "DELETE FROM [student_management].[dbo].[scores] WHERE id_scores = @IdScores";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, conn);
                    sqlCommand.Parameters.AddWithValue("@IdScores", id);
                    await sqlCommand.ExecuteNonQueryAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        /* UPDATE */
        public async Task<bool> UpdateScores(ScoresModel scoresModel)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    string sqlString = @"
                        UPDATE [student_management].[dbo].[scores]
                        SET 
                            [math] = @Math,
                            [basic_technology] = @BasicTechnology,
                            [physics] = @Physics,
                            [net_technology] = @NetTechnology,
                            [general_law] = @GeneralLaw,
                            [english] = @English,
                            [image_processing] = @ImageProcessing,
                            [id_student] = @IdStudent
                        WHERE id_scores = @IdScores";

                    SqlCommand sqlCommand = new SqlCommand(sqlString, connection);

                    sqlCommand.Parameters.AddWithValue("@Math", scoresModel.Math);
                    sqlCommand.Parameters.AddWithValue("@BasicTechnology", scoresModel.BasicTechnology);
                    sqlCommand.Parameters.AddWithValue("@Physics", scoresModel.Physics);
                    sqlCommand.Parameters.AddWithValue("@NetTechnology", scoresModel.NetTechnology);
                    sqlCommand.Parameters.AddWithValue("@GeneralLaw", scoresModel.GeneralLaw);
                    sqlCommand.Parameters.AddWithValue("@English", scoresModel.English);
                    sqlCommand.Parameters.AddWithValue("@ImageProcessing", scoresModel.ImageProcessing);
                    sqlCommand.Parameters.AddWithValue("@IdStudent", scoresModel.IdStudent);
                    sqlCommand.Parameters.AddWithValue("@IdScores", scoresModel.IdScores);

                    await sqlCommand.ExecuteNonQueryAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating scores: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
