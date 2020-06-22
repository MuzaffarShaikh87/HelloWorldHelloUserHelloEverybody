using System;

namespace HelloWorldUserEB
{
    public class Program
    {
        public static ConsoleKey keyPressed;

        public static ConsoleKey KeyPressed { get; set; }

        public static void Main()
        {
            Console.WriteLine("Hello World!");
            while (keyPressed != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress the Enter key to end this program...");
                keyPressed = Console.ReadKey().Key;
            }
        }

        public static void main()
        {
            throw new NotImplementedException();
        }
    }
}

