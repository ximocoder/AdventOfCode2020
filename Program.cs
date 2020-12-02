using System;

namespace ConsoleAppAdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello AdventOfCode!");

            Console.WriteLine("Choose the Day: ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "1":
                    Day1 d1 = new Day1();
                    Console.WriteLine($"Day1 resultA: {d1.GiveMeResultA()}");
                    Console.WriteLine($"Day1 resultB: {d1.GiveMeResultB()}");
                    break;
                case "2":
                    Day2 d2 = new Day2();
                    Console.WriteLine($"Day2 result A: {d2.GetNotValidPasswords(Day2.Part.epart1)}");
                    Console.WriteLine($"Day2 result B: {d2.GetNotValidPasswords(Day2.Part.epart2)}");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
