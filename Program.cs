using System;
using ToDo.Domain;

namespace ToDo
{
    class Program
    {
      static  Task[] tasksList = new Task[100];
    
        static int GetIndexPosition()
        {
            int result = -1;
            for (int i = 0; i < tasksList.Length; i++)
            {
                if (tasksList[i] != null)
                {
                    continue;
                }
                if (tasksList[i] == null)
                {
                    result = i;
                    break;
                }
                if (result == -1)
                {
                    throw new Exception("No avalible position");
                }
            }
            return result;
        }
        static void Main(string[] args)
        {

            bool ShouldRun = true;

            int taskIdCounter = 1;

           
         
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
                        

                        tasksList[GetIndexPosition()] = new Task(taskIdCounter++, title,dueDate);


                        Console.ReadKey();

                        break;
                    case ConsoleKey.D2:

                        Console.WriteLine("ID  Title                       Due date                    Completed");
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine();
                        foreach (var task in tasksList)
                        {
                            if (task  ==  null) continue;
                           Console.WriteLine($"{task.Id} {task.Title}{task.DueDate.ToString().PadLeft(25, ' ')}");
                        }
                    

                        Console.ReadKey();

                        break;
                    case ConsoleKey.D3:
                      
                        ShouldRun = false;

                        break;

                }

            }
        }


    }
}
