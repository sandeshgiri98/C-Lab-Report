using System;
using System.Data.SqlClient;

namespace CreateDatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server\\SQLExpress";
            string databaseName = "dotnet_sandesh";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create SQL command to create database
                    string createDatabaseQuery = $"CREATE DATABASE {databaseName}";

                    using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                    {
                        // Execute the command to create the database
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Database '{databaseName}' created successfully.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating database: {ex.Message}");
                }
            }
        }
    }
}
