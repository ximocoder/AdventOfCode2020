using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppAdventOfCode
{
    internal class Day6 : Day5
    {

        internal int GetSumOfCounts()
        {
            var lines = File.ReadAllLines(".\\Files\\day6_input.txt");

            List<Dictionary<char,int>> list = new List<Dictionary<char,int>>();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var line in lines)
            {
                foreach (var c in line)
                {
                    if (!dict.ContainsKey(c))
                        dict.Add(c, 1);
                }
                if (line.Trim().Length == 0)
                {
                    Dictionary<char, int> dictc = new Dictionary<char, int>(dict);
                    list.Add(dictc);
                    dict.Clear();
                }
            }

            int totalnum = 0;
            foreach (var item in list)
            {
                totalnum += item.Count;
            }

            return totalnum;
        }

        internal int GetSumOfCountsB()
        {
            var lines = File.ReadAllLines(".\\Files\\day6_input.txt");

            List<Dictionary<char, int>> list = new List<Dictionary<char, int>>();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            int numberofpeople = 0;
            int totalnum = 0;

            foreach (var line in lines)
            {
                numberofpeople += 1;
                foreach (var c in line)
                {                  
                    if (!dict.ContainsKey(c))
                        dict.Add(c, 1);
                    else
                        dict[c] = dict[c] + 1;
                }
                if (line.Trim().Length == 0)
                {
                    numberofpeople -= 1;
                    if (numberofpeople == 1)
                        totalnum += dict.Count;
                    else
                    {
                        foreach (var item in dict)
                        {
                            if (item.Value == numberofpeople)
                                totalnum += 1;
                        }
                    }
                    dict.Clear();
                    numberofpeople = 0;
                }
            }

        
            return totalnum;
        }
    }
}