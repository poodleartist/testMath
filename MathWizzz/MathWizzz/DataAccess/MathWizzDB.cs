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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TaiN_\Documents\Capstone\MathWizzz\MathWizzz\DataAccess\MathWizz.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
