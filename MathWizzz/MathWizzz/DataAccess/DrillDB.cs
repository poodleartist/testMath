using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.DataAccess
{
    public class DrillDB
    {
        
        
        public static bool AddCompletedDrill(Drill drill, Student student)
        {
            DateTime currentDateTime = new DateTime();
            currentDateTime = DateTime.UtcNow;

            SqlConnection connectionString = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO ActivityHistory (StudentId, DateTime, TotalQuestions, CorrectAnswers, SkillLevel, ActivityType) " +
                "VALUES (@StudentId, @DateTime, @TotalQuestions, @CorrectAnswers, @SkillLevel, @ActivityType)");

            command.Parameters.AddWithValue("@StudentId", student.UserId);
            command.Parameters.AddWithValue("@DateTime", currentDateTime);
            command.Parameters.AddWithValue("@TotalQuestions", drill.NumberOfQuestions);
            command.Parameters.AddWithValue("@CorrectAnswers", drill.NumberOfCorrectAnswers);
            command.Parameters.AddWithValue("@SkillLevel", drill.SkillLevel);
            command.Parameters.AddWithValue("@ActivityType", "Drill");

            try
            {
                connectionString.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connectionString.Close();
            }
        }
    }
}
