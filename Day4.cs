using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Values = System.Collections.Generic.IEnumerable<string>;

namespace ConsoleAppAdventOfCode
{
    internal class Day4
    {


        internal int GetNumberOfPasswords()
        {

            int numberOfPasswords = 0;
            int numberOfCorrectPasswords = 0;
            int numberOfCorrectPasswordsPartB = 0;
            var lines = File.ReadAllLines(".\\Files\\day4_input.txt");

            Dictionary<string, string> dc = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                var values = line.Split(new[] { '\n', ' ' }, StringSplitOptions.None);

                foreach (var item in values)
                {
                    var splitvalues = item.Split(':');
                    if (splitvalues.Length == 2)
                        dc.Add(splitvalues[0].Trim(), splitvalues[1].Trim());
                }
                if (line.Trim().Length == 0)
                {
                    numberOfPasswords += 1;
                    if (CheckPassword(dc))
                    {
                        numberOfCorrectPasswords += 1;
                        if (CheckPasswordPartB(dc))
                            numberOfCorrectPasswordsPartB += 1;
                    }
                    dc.Clear();
                }
            }
            return numberOfCorrectPasswords;
        }

        private bool CheckPassword(Dictionary<string, string> dc)
        {
            //byr(Birth Year)
            //iyr(Issue Year)
            //eyr(Expiration Year)
            //hgt(Height)
            //hcl(Hair Color)
            //ecl(Eye Color)
            //pid(Passport ID)
            //cid(Country ID)
            string[] values = new string[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };

            foreach (var value in values)
            {
                if (!dc.ContainsKey(value))
                    return false;
            }
            return true;
        }

        private bool CheckPasswordPartB(Dictionary<string, string> dc)
        {
 
            List<string> data = new List<string>() { @"byr:(200[0-2]|19[2-9][0-9])",
                                                     @"iyr:(2020|201[0-9])",
                                                     @"eyr:(2030|202[0-9])",
                                                     @"hgt:((1[5-8][0-9]|19[0-3])cm)|hgt:(7[0-6]|59|6[0-9])in",
                                                     @"hcl:(#[0-9a-f]{6})",
                                                     @"ecl:(amb|blu|brn|gry|grn|hzl|oth)",
                                                     @"pid:(\d{9}\b)" };

            foreach (string regex in data)
            {
                var valueFromDir = $"{regex.Split(":")[0]}:{dc[regex.Split(":")[0]]}";
                MatchCollection matches = Regex.Matches(valueFromDir, regex);
                if (matches.Count == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}