using System;

namespace ConsoleAppAdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello AdventOfCode 2020!");

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
                case "3":
                    Day3 d3 = new Day3();
                    Console.WriteLine($"Day3 result A: ");
                    Console.WriteLine($"Day3 result B: ");
                    break;
                case "4":
                    Day4 d4 = new Day4();
                    Console.WriteLine($"Day4 result A: ");
                    Console.WriteLine($"Day4 result B: ");
                    break;
                case "5":
                    Day5 d5 = new Day5();
                    Console.WriteLine($"Day5 result A: ");
                    Console.WriteLine($"Day5 result B: ");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
