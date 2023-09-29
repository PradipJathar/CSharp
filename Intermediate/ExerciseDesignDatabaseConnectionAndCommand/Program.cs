using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDesignDatabaseConnectionAndCommand
{
    class Program
    {
        static void Main(string[] args)
        {            
            SqlConnection sqlConnection = new SqlConnection("abcd123");
            sqlConnection.Open();
            sqlConnection.Close();

            OracleConnection oracleConnection = new OracleConnection("ab12cd34");
            oracleConnection.Open();
            oracleConnection.Close();

                        

            SqlConnection sqlConnection1 = new SqlConnection("asd1344");
            string sqlQuery = "SELECT * FORM Customers;";
            DbCommand dbSqlCommand = new DbCommand(sqlConnection1, sqlQuery);
            dbSqlCommand.Execute();


            OracleConnection oracleConnection1 = new OracleConnection("sdfedf123");
            string oracleQuery = "SELECT * FORM Employee;";
            DbCommand dbOracleCommand = new DbCommand(oracleConnection1, oracleQuery);
            dbOracleCommand.Execute();
        }
    }
}
