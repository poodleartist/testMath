using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    public class SkillLevelDB
    {
        public static SkillLevel GetSkillLevel(int skillLevel)
        {
            SqlConnection connection = MathWizzDB.GetConnection();
            string selectStatement = "SELECT SkillLevel.SkillLevel, NumberOfDigits, NumberOfDecimalPlaces, MathOperator, MinValue, MaxValue" +
                " FROM SkillLevel " +
                "INNER JOIN StudentInfo ON SkillLevel.SkillLevel = StudentInfo.SkillLevel " +
                "WHERE SkillLevel.SkillLevel = @skillLevel";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@skillLevel", skillLevel);

            try
            {
                connection.Open();
                SqlDataReader skillReader = selectCommand.ExecuteReader();
                if (skillReader.Read())
                {
                    SkillLevel skLevel = new SkillLevel();
                    skLevel.SkillLevelID = (int)skillReader["SkillLevel"];
                    skLevel.NumberOfDigits = (int)skillReader["NumberOfDigits"];
                    skLevel.NumberOfDecimalPlaces = (int)skillReader["NumberOfDecimalPlaces"];
                    skLevel.MinValue = (int)skillReader["MinValue"];
                    skLevel.MaxValue = (int)skillReader["MaxValue"];
                    skLevel.MathOperator = skillReader["MathOperator"].ToString();

                    return skLevel;
                } else
                {
                    return null;
                }
            } catch (SqlException ex)
            {
                throw ex;
            } finally
            {
                connection.Close();
            }

        }
    }
}
