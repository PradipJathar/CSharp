using System;

namespace ExerciseDesignDatabaseConnectionAndCommand
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }


        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Please provide connection string.");
            }

            this.ConnectionString = connectionString;
            this.Timeout = TimeSpan.FromSeconds(30);            // Default timeout of 30 seconds
        }


        public abstract void Open();

        public abstract void Close();

    }


    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Sql Connection Opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Sql Connection Closed.");
        }
    }


    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection Opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection Closed.");
        }
    }
}
