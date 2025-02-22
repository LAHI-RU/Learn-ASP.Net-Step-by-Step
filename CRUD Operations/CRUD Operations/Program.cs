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


        /*
        // Insert Data into MySQL (Create)
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Users(Name,Email,Age) VALUES (@Name, @Email, @Age)";

            using(MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", "Thimira");
                cmd.Parameters.AddWithValue("@Email", "thimira123@gmail.com");
                cmd.Parameters.AddWithValue("@Age", 25);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted successfully");
            }
        }
        */


        // Read Data from MySQL (Retrieve)
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query1 = "SELECT * from Users";

            using( MySqlCommand cmd = new MySqlCommand( query1, conn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]},Name: {reader["Name"]}, Email: {reader["Email"]}, Age: {reader["Age"]} ");
                }
            }
        }
        

        // Update Data in MySQL
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query2 = "UPDATE Users SET Age = @Age WHERE Name = @Name";

            using (MySqlCommand cmd = new MySqlCommand(query2, conn))
            {
                cmd.Parameters.AddWithValue("@Name", "Thimira");
                cmd.Parameters.AddWithValue("@Age", 30);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) updated successfully!");
            }
        }
        

        /*
        // Delete Data from MySQL
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query3 = "DELETE FROM Users WHERE Name = @Name";

            using (MySqlCommand cmd = new MySqlCommand(query3, conn))
            {
                cmd.Parameters.AddWithValue("@Name", "Shevon Fernando");

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted successfully!");
            }
        }
        */

    }
}