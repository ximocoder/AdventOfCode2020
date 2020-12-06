using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppAdventOfCode
{
    internal class Day5
    {
        private List<int> list;

        internal int GetHigherId()
        {
            var lines = File.ReadAllLines(".\\Files\\day5_input.txt");
            int higherId = 0;
            list = new List<int>();
            foreach (var line in lines)
            {
                int hid = Getid(line);
                if (hid > higherId)
                    higherId = hid;
            }
            list.Sort();
            int val;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] + 1 != list[i + 1])
                    val = list[i] + 1;
            }

            return higherId;

        }

        private int Getid(string line)
        {
            int row = BinarySearchRecursive(line.Substring(0, 7), 0, 0, 127);
            int col = BinarySearchRecursive(line.Substring(7, 3), 0, 0, 7);

            int id = (row * 8) + col;

            if (row > 0 && row < 127)
                list.Add(id);

            return id;
        }

        public static int BinarySearchRecursive(string inputArray, int key, int min, int max)
        {
            if (key >= inputArray.Length)
                return max;
            else
            {
                int mid = (min + max) / 2;

                if (inputArray[key] == 'F' || inputArray[key] == 'L')
                {
                    return BinarySearchRecursive(inputArray, key + 1, min, mid);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key + 1, mid + 1, max);
                }
            }
        }
    }
}