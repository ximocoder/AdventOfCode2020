using System;
using System.IO;
using System.Linq;

namespace ConsoleAppAdventOfCode
{
    internal class Day2
    {
        public enum Part
        {
            epart1,
            epart2
        }

        internal int GetNotValidPasswords(Part part)
        {
            var lines = File.ReadAllLines(".\\Files\\day2_input.txt");
            //var lines = File.ReadAllLines(".\\Files\\day2_input_small.txt");
            int numberPwd = 0;

            foreach (var line in lines)
            {

                var parts = line.Split(":");
                var policy = parts[0];
                var password = parts[1];

                if (CheckPolicy(part, policy, password))
                    numberPwd += 1;

            }

            return numberPwd;
        }

        private bool CheckPolicy(Part part, string policy, string password)
        {
            var parts = policy.Split(" ");
            var times = parts[0];
            var character = parts[1][0];
            int minimumTimes = int.Parse(times.Split("-")[0]);
            int maximumTimes = int.Parse(times.Split("-")[1]);

            int numtimes = password.ToCharArray().Count(c => c == character);

            switch (part)
            {
                case Part.epart1:
                    if (minimumTimes <= numtimes && numtimes <= maximumTimes)
                        return true;
                    break;
                case Part.epart2:
                    if (password[minimumTimes] == character && password[maximumTimes] == character)
                        return false;
                    if (password[minimumTimes] == character || password[maximumTimes] == character)
                        return true;
                    break;
                default:
                    break;
            }

            return false;
        }
    }
}