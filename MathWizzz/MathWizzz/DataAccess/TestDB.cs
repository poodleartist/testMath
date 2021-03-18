using MathWizzz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.DataAccess
{
    public class TestDB
    {

        public static bool AddCompletedTest (Test test, Student student, Models.ActivityHistory activity)
        {
            bool success = false;
            DateTime currentDateTime = new DateTime();
            currentDateTime = DateTime.UtcNow;

            SqlConnection connectionString = new SqlConnection();
            SqlCommand command = new SqlCommand("UPDATE ActivityHistory " +
                "SET DateTime = @DateTime, CorrectAnswers = @CorrectAnswers, SkillLevel = @SkillLevel, ActivityType = @ActivityType " +
                "WHERE ActivityID = @ActivityID)");

            //command.Parameters.AddWithValue("@StudentId", student.UserId);
            command.Parameters.AddWithValue("@DateTime", currentDateTime);
            //command.Parameters.AddWithValue("@TotalQuestions", test.NumberOfQuestions);
            command.Parameters.AddWithValue("@CorrectAnswers", test.NumberOfCorrectAnswers);
            command.Parameters.AddWithValue("@SkillLevel", test.SkillLevel);
            command.Parameters.AddWithValue("@ActivityType", activity.ActivityType);
            command.Parameters.AddWithValue("@ActivityID", test.ActivityID);

            command.Connection = connectionString;

            try
            {
                connectionString.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
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

            return success;
        }
    }
}
