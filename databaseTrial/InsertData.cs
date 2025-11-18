using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseTrial
{
    class InsertData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Insertion\n 2. Deletion \n 3. Updation \n 4. ReadData");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice <= 4)
            {

                switch (choice)
                {
                    case 1: insertData(); break;
                    case 2: deleteData(); break;
                   
                    
                    case 3: updateData(); break;
                    case 4: readData(); break;
                    default: Console.WriteLine("Invalid Choice"); break;

                }
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Insertion\n 2. Deletion \n 3. Updation \n 4. ReadData");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }


        static void insertData()
        {

            string connectionString = "Server = localhost; Database=testdb; User Id= root; Password=Gaurav@2004";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string insertQuery = "INSERT INTO Students(student_id,student_name,course,age) VALUES(@Id,@name,@course,@age)";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                Console.WriteLine("Enter Student Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Course:");
                string course = Console.ReadLine();
                Console.WriteLine("Enter Student Age:");
                int age = Convert.ToInt32(Console.ReadLine());
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@course", course);
                command.Parameters.AddWithValue("@age", age);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data Inserted Successfully!");
                }
                else
                {
                    Console.WriteLine("Data Insertion Failed!");
                }

            }
            catch (MySqlException err)
            {
                Console.Write(err.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection Closed.");
            }
        }

        static void deleteData()
        {
            string connectionString = "Server = localhost; Database=testdb; User Id= root; Password=Gaurav@2004";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string insertQuery = "DELETE FROM Students where student_id = @Id";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                Console.WriteLine("Enter Student Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                command.Parameters.AddWithValue("@Id", id);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data Deleted Successfully!");
                }
                else
                {
                    Console.WriteLine("Data Deletion Failed!");
                }

            }
            catch (MySqlException err)
            {
                Console.Write(err.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection Closed.");
            }
        }
        static void updateData()
        {

            string connectionString = "Server = localhost; Database=testdb; User Id= root; Password=Gaurav@2004";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string insertQuery = "UPDATE Students set student_name=@name where student_id=@Id";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                Console.WriteLine("Enter Student Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@name", name);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data Update Successfully!");
                }
                else
                {
                    Console.WriteLine("Data Updation Failed!");
                }

            }
            catch (MySqlException err)
            {
                Console.Write(err.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection Closed.");
            }
        }
        static void readData()
        {
            string connectionString = "Server = localhost; Database=testdb; User Id= root; Password=Gaurav@2004";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string insertQuery = "SELECT * FROM Students";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Student Id: " + reader["student_id"] + ", Name: " + reader["student_name"] + ", Course: " + reader["course"] + ", Age: " + reader["age"]);
                }
            }
            catch (MySqlException err)
            {
                Console.Write(err.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection Closed.");
            }

        }

    }
}
