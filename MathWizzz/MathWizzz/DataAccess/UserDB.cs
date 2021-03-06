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
        public static bool AddUser(Person person)
        {
            bool success = false;
            SqlConnection connectionString = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Users (UserName, Password, FirstName, LastName, UserRole)" +
                                                "VALUES('@UserName', '@Password', '@FirstName', '@LastName', '@UserRole')");

            command.Parameters.AddWithValue("@UserName", person.Username);
            command.Parameters.AddWithValue("@Password", person.Password);
            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            command.Parameters.AddWithValue("@UserRole", person.UserRole);

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

                // for testing
                Console.WriteLine("RowsAffected: {0}", rowsAffected);

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
