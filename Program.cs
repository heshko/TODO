using System;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ShouldRun = true;
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
                        Console.Clear();

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
