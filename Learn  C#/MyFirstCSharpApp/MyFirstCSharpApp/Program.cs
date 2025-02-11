using System;

class Program
{ 
    static void Main()
    {
        Console.WriteLine("Hello World!");

        /*
        // variables & data types
        string name = "Lahiru";
        int age = 25;
        double height = 5.11;
        bool isStudent = true;

        Console.WriteLine("Hello " + name + ", you are " + age + " years old!");
        
        // No need + concatination when use $ mark
        Console.WriteLine($"My name {name}, I am {age} years old.");
        */

        // Get input from the user
        /*
        Console.Write("Enter your name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hello {name1}, you are {age1} years old");
        */


        // Conditional Statements (if-else)
        /*
        Console.Write("Enter your age: ");
        int age2 = Convert.ToInt32(Console.ReadLine());
   

        if (age2 >= 18)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are a minor");
        }
        */


        // Loops (for, while)
        /*
        for (int i = 1; i <= 5; i++) 
        {
            Console.WriteLine($"Number: {i}");
        }

        int j = 1;
        while(j<=5)
        {
            Console.WriteLine($"Count: {j}");
            j++;    
        }
        */

        /*
        // Functions
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        GreetUser(userName);
        */

        /*
        // Array
        string[] fruits = { "Apple", "Banana", "Orange" };

        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }
        */

        Car myCar = new Car();
        myCar.brand = "BMW";
        myCar.year = 2025;

        Console.WriteLine($"Car: {myCar.brand}, Year: {myCar.year}");
        myCar.Drive();
   }
    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello {name}, Welcome to C#!");
    }

    class Car
    {
        public string brand;
        public int year;

        public void Drive()
        {
            Console.WriteLine($"{brand} is driving");
        }

    }

}

