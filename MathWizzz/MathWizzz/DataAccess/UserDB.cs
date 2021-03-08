using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    class UserDB
    {
        public static bool AddUser(string sql)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText += sql;
                    cmd.Connection = MathWizzDB.GetConnection();
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static Person GetUserByUserId(string userId)
        {
            SqlConnection connection = MathWizzDB.GetConnection();
            string sqlState = "Select LastName, FirstName, UserRole from Users where UserId = @userId";

            SqlCommand cmd = new SqlCommand(sqlState, connection);
            cmd.Parameters.AddWithValue("UserId", userId);

            try
            {
                connection.Open();
                SqlDataReader userReader = cmd.ExecuteReader();
                
                if(userReader.Read())
                {
                    Person person = new Person();
                    person.FirstName = userReader["FirstName"].ToString();
                    person.LastName = userReader["LastName"].ToString();
                    person.UserRole = userReader["UserRole"].ToString();
                    return person;
                }
                else
                {
                    return null;
                }

            }
            catch(SqlException ex)
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
