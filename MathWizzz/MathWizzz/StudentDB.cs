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



    }
}
