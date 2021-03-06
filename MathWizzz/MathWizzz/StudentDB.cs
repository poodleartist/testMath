using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    class StudentDB
    {
        public static Student GetStudentById(int studentId)
        {
            SqlConnection connection = MathWizzDB.GetConnection();
            string selectStatement = "SELECT StudentId, StudentLevel," +
                "ClassId,FirstName FROM StudentInfo" +
                "JOIN Users on StudentId = UserId" +
                "WHERE StudentId = @StudentId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@StudentId", studentId);
            try
            {
                connection.Open();
                SqlDataReader studentReader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if(studentReader.Read())
                {
                    Student student = new Student();
                    student.StudentID = (int)studentReader["StudentId"];
                    student.FirstName = studentReader["FirstName"].ToString();
                    student.StudentLevel = (int)studentReader["StudentLevel"];
                    student.ClassID = (int)studentReader["ClassId"];
                    return student;
                }
                else
                {
                    return null;
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
 
        public static bool AddStudent(int UserId)
        {
            bool success = false;
            SqlConnection connection = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO StudentInfo(StudentId) +" +
                                                "VALUES('@UserId', (SELECT UserId" +
                                                                       "FROM Users" +
                                                                       "WHERE UserId = " + UserId + "))");
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

        public static bool GivePointsToStudent(Student student, int rewardPoints)
        {
            bool success = false;
            SqlConnection connection = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO StudentInfo(RewardPoints) +" +
                                                "VALUES('@RewardPoints')" +
                                                "WHERE StudentId = @StudentId");

            command.Parameters.AddWithValue("@RewardPoints", rewardPoints);
            command.Parameters.AddWithValue("@Student", student.StudentID);
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

        public static bool AssignClassToStudent(Student student, int classId)
        {
            bool success = false;
            SqlConnection connection = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO StudentInfo(ClassId) +" +
                                                "VALUES('@ClassId')" +
                                                "WHERE StudentId = @StudentId");

            command.Parameters.AddWithValue("@ClassId", classId);
            command.Parameters.AddWithValue("@Student", student.StudentID);
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
