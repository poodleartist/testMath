using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    class DataAccess
    {
        public bool AddUser(Person person)
        {
            bool success = false;
            SqlConnection connectionString = MathWizzDB.GetConnection();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Users (UserName, Password, FirstName, LastName, UserRole)" +
                                                "VALUES(@UserName, @Password, @FirstName, @LastName, @UserRole)");

                command.Parameters.AddWithValue("@UserName", person.Username);
                command.Parameters.AddWithValue("@Password", person.Password);
                command.Parameters.AddWithValue("@FirstName", person.FirstName);
                command.Parameters.AddWithValue("@LastName", person.LastName);
                command.Parameters.AddWithValue("@UserRole", person.UserRole);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        success = true;
                    } else
                    {
                        success = false;
                    }

                    // for testing
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    
                }
                catch
                {

                }
            }

            return success;
        }

    }
}
