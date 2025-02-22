using System;
using MySql.Data.MySqlClient;  // Import MySQL Library

class Program
{
    static void Main()
    {

        // C# Code to Connect .NET with WAMP’s MySQL
        string connectionString = "server=localhost;database=testdb;user=root;password=;";

        /*
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("Connected to MySQL successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        */


        // Insert Data into MySQL (Create)

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Users(Name,Email,Age) VALUES (@Name, @Email, @Age)";

            using(MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", "Lahiru Bandara");
                cmd.Parameters.AddWithValue("@Email", "lahiru123@gmail.com");
                cmd.Parameters.AddWithValue("@Age", 25);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted successfully");
            }
        }
    }
}