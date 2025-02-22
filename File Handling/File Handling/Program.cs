using System;
using System.IO;
class Program
{
    static void Main()
    {
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


    }
}