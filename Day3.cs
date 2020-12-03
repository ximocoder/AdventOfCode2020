using System;
using System.IO;
using System.Text;

namespace ConsoleAppAdventOfCode
{
    internal class Day3
    {
        public Day3()
        {

        }

        internal int GetNumberOfTrees()
        {
            var lines = File.ReadAllLines(".\\Files\\day3_input.txt");
            int sizeOfMatrixRows = lines.Length;
            int numberOfTrees = 0;

            for (int l = 0; l < lines.Length; l++)
            {
                lines[l] = Repeat(lines[l], 1000);
            }

            int i = 0;
            for (int j = 0; j < lines[0].Length; j += 3)
            {
                if (i < sizeOfMatrixRows && lines[i][j] == '#')
                    numberOfTrees += 1;
                i += 1;
            }

            return numberOfTrees;
        }

        internal double GetNumberOfTreesPart2()
        {
            var lines = File.ReadAllLines(".\\Files\\day3_input.txt");
            int sizeOfMatrixRows = lines.Length;
            for (int l = 0; l < lines.Length; l++)
            {
                lines[l] = Repeat(lines[l], 1000);
            }

            ////Right 1, down 1.
            ////Right 3, down 1. (This is the slope you already checked.)
            ////Right 5, down 1.
            ////Right 7, down 1.
            ////Right 1, down 2.

            var A = CheckTrees(lines, sizeOfMatrixRows, 1, 1);
            var B = CheckTrees(lines, sizeOfMatrixRows, 3, 1);
            var C = CheckTrees(lines, sizeOfMatrixRows, 5, 1);
            var D = CheckTrees(lines, sizeOfMatrixRows, 7, 1);
            var E = CheckTrees(lines, sizeOfMatrixRows, 1, 2);

            double multiplyResult = A * B * C * D * E;
            return multiplyResult;
        }

        private static double CheckTrees(string[] lines, int sizeOfMatrixRows, int right, int down)
        {
            int i = 0;
            double numberOfTrees = 0;
            for (int j = 0; j < lines[0].Length; j += right)
            {
                if (i < sizeOfMatrixRows && lines[i][j] == '#')
                    numberOfTrees += 1;
                i += down;
            }

            return numberOfTrees;
        }

        internal string Repeat(string input, int count)
        {
            if (!string.IsNullOrEmpty(input))
            {
                StringBuilder builder = new StringBuilder(input.Length * count);

                for (int i = 0; i < count; i++) builder.Append(input);

                return builder.ToString();
            }

            return string.Empty;
        }
    }
}