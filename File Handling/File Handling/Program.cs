using System;
using System.IO;
class Program
{
    static void Main()
    {
        /*
        // Create a File and Write Data
        string filePath = "test.txt";

        try
        {
            File.WriteAllText(filePath, "Hello, this is my first file in C#!");
            Console.WriteLine("File created and written successfully");
        }

        catch (Exception ex) 
        { 
          Console.WriteLine("Error: " +  ex.Message);  
        }
        */


        /*
        // Read and Display File Content 
        string filePath = "test1.txt";

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content: ");
            Console.WriteLine(content);
        }

        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        */


        /*
        // Append Data to File
        string filePath = "test.txt";

        try
        {
            File.AppendAllText(filePath, "\nThis is new appended text.");
            Console.WriteLine("Text append successfully!");
        }

        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        */


        /*
        // Delete a File
        string filePath = "test.txt";

        try
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        */


        // Check File Existence
        string filePath = "test.txt";

        if (File.Exists(filePath))
        {
            Console.WriteLine("The file exists.");
        }

        else
        {
            Console.WriteLine("File does not exist.");
        }

        Console.ReadLine();
        
    }
}