using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleAppAdventOfCode
{
    internal class Day7
    {
        struct node
        {
            public string name;
            public int number;
        }
        internal int GetNumberOfBagsCanContainOneShinnyGoldBag()
        {
            int result = 0;
            var lines = File.ReadAllLines(".\\Files\\day7_input.txt");
            Dictionary<string, List<node>> dict = new Dictionary<string, List<node>>();
            Dictionary<string, int> contains = new Dictionary<string, int>();

            foreach (var line in lines)
            {
                var parts = line.Split("contain");

                var parent = parts[0].Replace("bags", "").Replace("bag", "").Trim();
                var children = parts[1].Substring(0, parts[1].Length - 1).Split(',');

                List<node> list = new List<node>();
                foreach (var ch in children)
                {
                    if (!ch.Contains("no other bags"))
                    {
                        node nd = new node();

                        nd.number = int.Parse(ch.Trim().Split(' ')[0]);
                        nd.name = ch.Trim().Replace(ch.Trim().Split(' ')[0], "").Replace("bags", "").Replace("bag", "").Trim();

                        list.Add(nd);

                        if (nd.name.Contains("shiny gold"))
                            contains.Add(parent, nd.number);
                    }
                }
                dict.Add(parent, list);
            }

            foreach (var bag in dict)
            {
                foreach (var bagv in bag.Value)
                {
                    if (bagv.name.Contains("shiny gold"))
                    {
                        result++;
                        break;
                    }
                    else if (contains.ContainsKey(bagv.name))
                    {
                        result++;
                        break;
                    }

                }
            }

            return result;
        }
    }

}