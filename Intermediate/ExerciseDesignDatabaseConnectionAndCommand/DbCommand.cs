using System;

namespace ExerciseDesignDatabaseConnectionAndCommand
{
    public class DbCommand
    {
        private DbConnection DbConnection { get; set; }
        private string Query { get; set; }

        public DbCommand(DbConnection dbConnection, string query)
        {
            if (dbConnection == null)
            {
                throw new InvalidOperationException("Please provide the DBConnection.");
            }

            if (String.IsNullOrWhiteSpace(query))
            {
                throw new InvalidOperationException("Please provide the query.");
            }


            this.DbConnection = dbConnection;
            this.Query = query;
        }


        public void Execute()
        {
            DbConnection.Open();

            Console.WriteLine($"Executing command: {Query}");

            DbConnection.Close();
        }
    }
}
