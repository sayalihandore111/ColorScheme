using System;

namespace ConsoleAppDemo7
{
    class Program
    {
        static void Main(string[] args)
        {
            string c1, c2;
            Console.Write("Enter first color: ");
            c1 = Console.ReadLine();
            Console.Write("Enter first color: ");
            c2 = Console.ReadLine();
            if (c1 == "RED" && c2 == "GREEN" || c1 == "GREEN" && c2 == "RED")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Switched to Yellow");
            }
            else if (c1 == "RED" && c2 == "BLUE" || c1 == "BLUE" && c2 == "RED")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Switched to Magenta");
            }
            else if (c1 == "BLUE" && c2 == "GREEN" || c1 == "GREEN" && c2 == "BLUE")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Switched to Cyan");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.ReadKey();
        }
    }
}
