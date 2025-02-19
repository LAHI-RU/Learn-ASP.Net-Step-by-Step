using System;

class Program
{
    static void Main()
    {
        /*
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yo entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Program Ended");
        }
        */


        /*
        try
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("⚠ Error: Cannot divide by zero!");
        }
        */


        /*
        try
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("⚠ Error: Please enter valid numbers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("⚠ Error: Cannot divide by zero!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("⚠ Unexpected Error: " + ex.Message);
        }
        */


        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("⚠ Error: Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("✅ Program execution completed.");
        }

    }

}