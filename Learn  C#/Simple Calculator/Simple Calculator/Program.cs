using System;

class Program
{
    static void Addition(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    static void Substraction(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    static void Multiplication(int a, int b)
    {
        Console.WriteLine($"{a} x {b} = {a * b}");
    }

    static void Division(int a, int b)
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
    }

    static void Main()
    {
        Console.Write("Enter the First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Operator(+,-,*,/): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter the Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case '+':
                Addition(num1, num2);
                break;
            case '-':
                Substraction(num1, num2);
                break;
            case '*':
                Multiplication(num1, num2);
                break;
            case '/':
                if (num2 != 0)
                    Division(num1, num2);
                else
                    Console.WriteLine("Error! Division by zero.");
                return;
            default:
                Console.WriteLine("Invalid operator!");
                return;
        }
    }
}