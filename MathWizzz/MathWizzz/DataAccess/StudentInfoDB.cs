using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.DataAccess
{
   public class StudentInfoDB
    {
        public static bool AddToStudentInfo(Student student)
        {
            bool success = false;
            SqlConnection connection = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO StudentInfo (StudentId, SkillLevel, ClassId)" +
                                                "VALUES(@StudentId, @SkillLevel, @ClassId)", connection);


            command.Parameters.AddWithValue("@StudentId", student.userId);
            command.Parameters.AddWithValue("@SkillLevel", student.StudentLevel);
            command.Parameters.AddWithValue("@ClassId", student.ClassID);


            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

                // for testing
                Console.WriteLine("RowsAffected: {0}", rowsAffected);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return success;
        }
    }
}
