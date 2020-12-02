using System;

namespace ConsoleAppAdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello AdventOfCode!");

            //Day1 d1 = new Day1();

            //int res = d1.GiveMeResultA();
            //int res2 = d1.GiveMeResultB();

            Day2 d2 = new Day2();
            int result1d2 = d2.GetNotValidPasswords(Day2.Part.epart1);
            Console.WriteLine($"Day result: {result1d2}");

            int result2d2 = d2.GetNotValidPasswords(Day2.Part.epart2);
            Console.WriteLine($"Day result: {result2d2}");

            Console.ReadLine();
        }
    }
}
