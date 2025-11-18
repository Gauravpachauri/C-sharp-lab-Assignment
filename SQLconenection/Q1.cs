using System;
using System.Data.SqlClient;

namespace DatabaseConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the connection string
            string connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;";

            // Create SqlConnection instance
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    Console.WriteLine("Connection established successfully");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error while connecting to the database:");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Ensure connection is closed
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Connection closed successfully");
                    }
                }
            }

            // Wait for user confirmation before exit
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
