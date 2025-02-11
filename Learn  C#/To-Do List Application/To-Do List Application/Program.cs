using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nTo-Do List:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option! Try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Task added!");
    }

    static void ViewTasks()
    {
        Console.WriteLine("\nYour Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    static void DeleteTask()
    {
        ViewTasks();
        Console.Write("Enter task number to delete: ");
        int taskNum = Convert.ToInt32(Console.ReadLine());

        if (taskNum > 0 && taskNum <= tasks.Count)
        {
            tasks.RemoveAt(taskNum - 1);
            Console.WriteLine("Task deleted!");
        }
        else
        {
            Console.WriteLine("Invalid task number!");
        }
    }
}
