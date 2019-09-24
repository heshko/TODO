using System;
using ToDo.Domain;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ShouldRun = true;

            Task[] tasks = new Task[100];
            int countTaks = 0;
            while (ShouldRun)
            {
                Console.Clear();

                Console.WriteLine("1. Add Todo ");
                Console.WriteLine("2 .List  Todo!");
                Console.WriteLine("3. Exit");

                ConsoleKeyInfo PressedKey = Console.ReadKey();
                Console.Clear();
                switch (PressedKey.Key)
                {
                    case ConsoleKey.D1:
                        Console.Write("Title: ");

                        string title = Console.ReadLine();

                        Console.Write("Due date (yyyy-mm-dd hh:mm):");

                        DateTime dueDate = DateTime.Parse(Console.ReadLine());
                       


                        Task task = new Task(title,dueDate);
                        tasks[0] = task;
                      
                        Console.ReadKey();

                        break;
                    case ConsoleKey.D2:
                       
                        break;
                    case ConsoleKey.D3:
                      
                        ShouldRun = false;

                        break;

                }

            }
        }
    }
}
