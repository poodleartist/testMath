using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    public class StudentDB
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


        // When the student log in this function will check the username and password
        // If the account exist it return a student object.
        public static Student GetStudentInfo(string username, string password)
        {
            SqlConnection connection = MathWizzDB.GetConnection();
            string selectStatement = " SELECT StudentId, StudentLevel " +
                " ,FirstName, LastName, UserName, Password, UserRole  FROM StudentInfo " +
                " JOIN Users on StudentId = UserId " +
                " WHERE (UserName = @username) AND (Password = @password)";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@username", username);
            selectCommand.Parameters.AddWithValue("@password", password);
            try
            {
                connection.Open();
                SqlDataReader studentReader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (studentReader.Read())
                {
                    Student student = new Student();

                    student.StudentID = (int)studentReader["StudentId"];
                    student.FirstName = studentReader["FirstName"].ToString();
                    student.LastName = studentReader["LastName"].ToString();
                    student.Username = studentReader["UserName"].ToString();
                    student.Password = studentReader["Password"].ToString();
                    student.StudentLevel = (int)studentReader["StudentLevel"];
                    student.ClassID = (int)studentReader["ClassId"];

                    return student;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
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
