using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppAdventOfCode
{
    internal class Day9
    {
        internal int GetFirstNumber()
        {
            int res = 0;
            int firstDigits = 25;

            var lines = File.ReadAllLines(".\\Files\\day9_input.txt");

            int first = 0;
            for (int i = firstDigits; i < lines.Length; i++)
            {
                if (!IsSumOfPreviousOnes(int.Parse(lines[i]), lines.SubArray(first, firstDigits)))
                    res = int.Parse(lines[i]);
                first++;

            }   

            return res;
        }

        private bool IsSumOfPreviousOnes(int number, string[] strarray)
        {
            int ii = 0;
            int ij = 0;

            for (int i = 0; i < strarray.Length; i++)
            {
                for (int j = 0; j < strarray.Length; j++)
                {
                    ii = int.Parse(strarray[i]);
                    ij = int.Parse(strarray[j]);

                    if ( ii + ij == number)
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