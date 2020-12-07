using System;

namespace ConsoleAppAdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello AdventOfCode 2020!");

            Console.WriteLine("Choose the Day: ");
            //string day = Console.ReadLine();
            string day = "7";

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
                    Console.WriteLine($"Day3 result A: {d3.GetNumberOfTrees()}");
                    Console.WriteLine($"Day3 result B: {d3.GetNumberOfTreesPart2()}");
                    break;
                case "4":
                    Day4 d4 = new Day4();
                    Console.WriteLine($"Day4 result A:  {d4.GetNumberOfPasswords()}");
                    break;
                case "5":
                    Day5 d5 = new Day5();
                    Console.WriteLine($"Day5 result A: {d5.GetHigherId()}");
                    Console.WriteLine($"Day5 result B: ");
                    break;
                case "6":
                    Day6 d6 = new Day6();
                    //Console.WriteLine($"Day6 result A: {d6.GetSumOfCounts()}");
                    Console.WriteLine($"Day6 result B: {d6.GetSumOfCountsB()}");
                    break;
                case "7":
                    Day7 d7 = new Day7();
                    Console.WriteLine($"Day7 result A: {d7.GetNumberOfBagsCanContainOneShinnyGoldBag()}");
                    break;
                case "8":
                    Day8 d8 = new Day8();
                    //Console.WriteLine($"Day7 result A: {d7.GetSumOfCounts()}");
                    break;
                case "9":
                    Day9 d9 = new Day9();
                    //Console.WriteLine($"Day7 result A: {d7.GetSumOfCounts()}");
                    break;
                case "10":
                    Day10 d10 = new Day10();
                    //Console.WriteLine($"Day7 result A: {d7.GetSumOfCounts()}");
                    break;
                case "11":
                    Day11 d11 = new Day11();
                    //Console.WriteLine($"Day7 result A: {d7.GetSumOfCounts()}");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
