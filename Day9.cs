using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppAdventOfCode
{
    internal class Day9
    {
        private const int firstDigits = 25;
        private const string Path = ".\\Files\\day9_input.txt";

        internal double GetFirstNumber()
        {
            int res = 0;

            var lines = File.ReadAllLines(Path);

            int first = 0;
            for (int i = firstDigits; i < lines.Length; i++)
            {
                if (!IsSumOfPreviousOnes(int.Parse(lines[i]), lines.SubArray(first, firstDigits)))
                    res = int.Parse(lines[i]);
                first++;

            }

            return res;
        }

        internal double GetSecondNumber()
        {
            int res = 0;
            double firstNumber = 41682220d; //GetFirstNumber();

            var lines = File.ReadAllLines(Path);

            double sum = 0;
            int firstDigits = 0;

            int i = 0;
            while (i < lines.Length - 1)
            {
                int j = i;
                while (sum < firstNumber)
                {
                    sum += double.Parse(lines[j]);
                    j++;
                }
                if (sum == firstNumber)
                {
                    var ress = lines.SubArray(i, j - i);

                    return GetSumSmallAndBig(ress);
                }

                sum = 0;
                i++;
            }

            return sum;
        }

        private double GetSumSmallAndBig(string[] ress)
        {
            double small = double.Parse(ress[0]);
            foreach (var item in ress)
            {
                if (double.Parse(item) < small)
                    small = double.Parse(item);
            }

            double big = double.Parse(ress[0]);
            foreach (var item in ress)
            {
                if (double.Parse(item) > big)
                    big = double.Parse(item);
            }

            return big + small;
        }

        private bool IsSumOfPreviousOnes(int number, string[] strarray)
        {
            for (int i = 0; i < strarray.Length; i++)
            {
                for (int j = 0; j < strarray.Length; j++)
                {
                    int ii = int.Parse(strarray[i]);
                    int ij = int.Parse(strarray[j]);
                    if (ii + ij == number)
                        return true;
                }
            }

            return false;
        }
    }

    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            return new List<T>(array)
                        .GetRange(offset, length)
                        .ToArray();
        }
    }
}