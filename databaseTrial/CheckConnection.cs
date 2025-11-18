using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace databaseTrial
{
    class CheckConnection
    {
        static void Main1(string[] args)
        {
            string connectionString = "Server = localhost; Database=testdb; User Id= root; Password=Gaurav@2004";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Successful!");
            }
            catch(MySqlException err)
            {
                Console.Write(err.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
