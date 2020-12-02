using System;
using System.IO;

namespace ConsoleAppAdventOfCode
{
    internal class Day1
    {

        internal int GiveMeResultA()
        {
            var lines = File.ReadAllLines(".\\Files\\day1_input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length; j++)
                {
                    int ii = int.Parse(lines[i]);
                    int ij = int.Parse(lines[j]);

                    if (lines[i] != lines[j] && (ii + ij == 2020))
                        return ii * ij;
                }

            }

            return 0;
        }

        internal int GiveMeResultB()
        {
            var lines = File.ReadAllLines(".\\Files\\day1_input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length; j++)
                {
                    for (int k = 0; k < lines.Length; k++)
                    {
                        int ii = int.Parse(lines[i]);
                        int ij = int.Parse(lines[j]);
                        int ik = int.Parse(lines[k]);

                        if (lines[i] != lines[j] && lines[k] != lines[j] && (ii + ij + ik == 2020))
                            return ii * ij * ik;
                    }


                }

            }

            return 0;
        }
    }
}