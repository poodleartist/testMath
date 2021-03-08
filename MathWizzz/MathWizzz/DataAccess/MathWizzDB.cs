using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    class MathWizzDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=D:\code\2021_spring\PC&Stone\group_001\testMath\MathWizzz\MathWizzz\DataAccess\MathMizz.mdf;
                Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
