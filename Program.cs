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
                Console.WriteLine("1. Add Todo ");
                Console.WriteLine("2 .List  Tado!");
                Console.WriteLine("3. Exit");

                ConsoleKeyInfo PressedKey = Console.ReadKey();
                switch (PressedKey.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();

                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        ShouldRun = false;

                        break;

                }

            }
        }
    }
}
