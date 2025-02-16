using System;

class Program
{
    static void Main()
    {
        /*
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
        Console.ReadLine();
        */

        // Simple calculator

        Console.WriteLine("Enter First number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("Sum: " + sum);
        Console.ReadLine();
    }
}