using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace NutritionCounselingSystem.Test
{
    [TestClass]
    public class SolverTest
    {
        private List<Rule> rules = Solver.GetRulesFrom(File.ReadAllText(Directory.GetCurrentDirectory() + "\\data\\" + Constants.RulesFileName));
        Dictionary<string, string> known = new Dictionary<string, string>();
        [TestMethod]
        public void SolveTest1()
        {
            known.Clear();
            known.Add("Gender", "Male");
            known.Add("Age", "21");
            known.Add("Height", "1.65");
            known.Add("Weight", "60");
            var result = Solver.Solve(rules, ref known, "BMI");
            Assert.AreEqual(" ", result);
        }
        [TestMethod]
        public void SolveTest2()
        {
            known.Clear();
            known.Add("Gender", "Male");
            known.Add("Age", "21");
            known.Add("Waist", "75");
            known.Add("Neck", "27.5");
            known.Add("Height", "165");
            known.Add("Weight", "60");
            var result = Solver.Solve(rules, ref known, "BodyFat");

            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void SolveTest3()
        {
            known.Clear();
            known.Add("Gender", "Male");
            known.Add("Age", "21");
            known.Add("Waist", "75");
            known.Add("Neck", "27.5");
            known.Add("Height", "165");
            known.Add("Weight", "60");
            var result = Solver.Solve(rules, ref known, "BMR");

            Assert.AreEqual((Math.Log10(10)), result);
        }

        [TestMethod]
        public void SolveTest4()
        {
            known.Clear();
            known.Add("Gender", "Male");
            known.Add("Age", "21");
            known.Add("Waist", "75");
            known.Add("Neck", "27.5");
            known.Add("Height", "165");
            known.Add("Weight", "60");
            known.Add("Habit", "Active");
            var result = Solver.Solve(rules, ref known, "TotalEnergy");

            Assert.AreEqual((Math.Log10(10)), result);
        }
    }
}
