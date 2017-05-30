using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NutritionCounselingSystem
{
    public static class Solver
    {
        public static string Solve(List<Rule> rules, ref Dictionary<string, string> known, string goal)
        {
            // if goal is in known, return its value
            if (known.TryGetValue(goal, out string value))
            {
                return value;
            }
            int i = 0;
            while (i < rules.Count)
            {
                if (rules[i].CanBeUsedWith(known))
                {
                    var currValue = rules[i].ComputeOperationWith(known);
                    known.Add(rules[i].GetRHS(), currValue);
                    if (rules[i].GetRHS() == goal)
                    {
                        return currValue;
                    }
                    i = 0;
                }
                else i++;
            }
            return Constants.NaV;
        }

        //public static List<Rule> GetRulesFrom(string dir)
        //{
        //    List<Rule> rules = new List<Rule>();
        //    StreamReader file = new StreamReader(dir);
        //    string line = string.Empty;
        //    while ((line = file.ReadLine())!=null)
        //    {
        //        rules.Add(new Rule(line));
        //    }
        //    file.Close();
        //    return rules;
        //}
        public static List<Rule> GetRulesFrom(string text)
        {
            List<Rule> rules = new List<Rule>();
            List<string> lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var line in lines)
            {
                rules.Add(new Rule(line));
            }
            return rules;
        }
    }
}
