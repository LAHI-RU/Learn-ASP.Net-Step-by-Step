using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        File.WriteAllText("data.txt", "User Name: " + name);
        Console.WriteLine("Data saved to file!");
    }
}