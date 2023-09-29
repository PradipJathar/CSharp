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

        }
    }
}
