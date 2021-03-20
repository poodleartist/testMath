using MathWizzz.Models;
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
        
        
        public static bool AddCompletedPlacement(PlacementTest placement, Student student)
        {
            DateTime currentDateTime = new DateTime();
            currentDateTime = DateTime.UtcNow;

            SqlConnection connection = MathWizzDB.GetConnection();
            String selectStatement = "INSERT INTO ActivityHistory (StudentId, DateTime, TotalQuestions, CorrectAnswers, SkillLevel, ActivityType)" +
                "VALUES (@StudentId, @DateTime, @TotalQuestions, @CorrectAnswers, @SkillLevel, @ActivityType)";
            SqlCommand command = new SqlCommand(selectStatement, connection);

            command.Parameters.AddWithValue("@StudentId", (student.UserId));
            command.Parameters.AddWithValue("@DateTime", currentDateTime);
            command.Parameters.AddWithValue("@TotalQuestions", placement.NumberOfQuestions);
            command.Parameters.AddWithValue("@CorrectAnswers", placement.NumberOfCorrectAnswers);
            command.Parameters.AddWithValue("@SkillLevel", student.studentLevel);
            command.Parameters.AddWithValue("@ActivityType", "Placement");

            try
            {
                connection.Open();

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
                connection.Close();
            }
        }

        public static bool AddCompletedDrill(Drill drill, Student student)
        {
            DateTime currentDateTime = new DateTime();
            currentDateTime = DateTime.UtcNow;

            SqlConnection connection = MathWizzDB.GetConnection();
            String selectStatement = "INSERT INTO ActivityHistory (StudentId, DateTime, TotalQuestions, CorrectAnswers, SkillLevel, ActivityType)" +
                "VALUES (@StudentId, @DateTime, @TotalQuestions, @CorrectAnswers, @SkillLevel, @ActivityType)";
            SqlCommand command = new SqlCommand(selectStatement, connection);

            command.Parameters.AddWithValue("@StudentId", student.UserId);
            command.Parameters.AddWithValue("@DateTime", currentDateTime);
            command.Parameters.AddWithValue("@TotalQuestions", drill.NumberOfQuestions);
            command.Parameters.AddWithValue("@CorrectAnswers", drill.NumberOfCorrectAnswers);
            command.Parameters.AddWithValue("@SkillLevel", student.StudentLevel);
            command.Parameters.AddWithValue("@ActivityType", "Drill");

            try
            {
                connection.Open();

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
                connection.Close();
            }
        }
    }
}
