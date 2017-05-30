using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCounselingSystem.Test
{
    [TestClass]
    public class RuleTest
    {
        [TestMethod]
        public void Ctor_Test1()
        {
            Rule r = new Rule("(BMI >= 18.5) && (BMI <= 25) # BMI # State # \"Normal\"");
            string result = r.ToString();
            Assert.AreEqual("(BMI >= 18.5) && (BMI <= 25) || BMI -> State = \"Normal\"", result);
        }

        [TestMethod]
        public void Ctor_Test2()
        {
            Rule r = new Rule("NONE # Height,Weight # BMI # Weight/(Height*Height)");
            string result = r.ToString();
            Assert.AreEqual("NONE || Height Weight -> BMI = Weight/(Height*Height)", result);
        }

        [TestMethod]
        public void LHSIsSubset_Test1()
        {
            Rule r = new Rule("NONE # Height,Weight # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("Gender", "Male");
            known.Add("BMR", "25.0");
            known.Add("Weight", "65");
            var actual = r.LHSIsSubsetOf(known);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void LHSIsSubset_Test2()
        {
            Rule r = new Rule("NONE # Height,Weight # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("Gender", "Male");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.LHSIsSubsetOf(known);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CheckCondition_Test1()
        {
            Rule r = new Rule("NONE # Height,Weight # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("Gender", "Male");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CheckConditionWith(known);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CheckCondition_Test2()
        {
            Rule r = new Rule("Gender == \"Male\" # Gender,Height,Weight # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("Gender", "Male");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CheckConditionWith(known);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CheckCondition_Test3()
        {
            Rule r = new Rule("(Gender == \"Female\") # Gender, Height,Weight # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("Gender", "Male");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CheckConditionWith(known);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void CheckCondition_Test4()
        {
            Rule r = new Rule("(BodyFat >= 4) && (BodyFat <= 17) # BodyFat # State # \"Good\"");
            Dictionary <string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "12");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CheckConditionWith(known);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CheckCondition_Test5()
        {
            Rule r = new Rule("(BodyFat >= 4) && (BodyFat <= 17) # BodyFat # State # \"Good\"");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CheckConditionWith(known);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void CanBeUsed_Test1()
        {
            Rule r = new Rule("(BodyFat >= 4) && (BodyFat <= 17) # BodyFat # State # \"Good\"");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "12");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CanBeUsedWith(known);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CanBeUsed_Test2()
        {
            Rule r = new Rule("(BodyFat >= 4) && (BodyFat <= 17) # BodyFat # State # \"Good\"");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("State", "Thin");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CanBeUsedWith(known);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void CanBeUsed_Test3()
        {
            Rule r = new Rule("(BodyFat >= 4) && (BodyFat <= 17) # BodyFat, Gender # State # \"Good\"");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "12");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CanBeUsedWith(known);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void CanBeUsed_Test4()
        {
            Rule r = new Rule("(BodyFat >= 4) && (BodyFat <= 17) # BodyFat # State # \"Good\"");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "2");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.CanBeUsedWith(known);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ComputeOperation_Test1()
        {
            Rule r = new Rule("(BodyFat >= 4) && (BodyFat <= 17) # BodyFat # State # _Good");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "14");
            known.Add("Height", "25.0");
            known.Add("Weight", "65");
            var actual = r.ComputeOperationWith(known);
            Assert.AreEqual("Good", actual);
        }

        [TestMethod]
        public void ComputeOperation_Test2()
        {
            Rule r = new Rule("NONE # Height,Weight # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "1.72");
            known.Add("Height", "1.72");
            known.Add("Weight", "75");
            var actual = r.ComputeOperationWith(known);
            Assert.AreEqual((75/(1.72*1.72)).ToString(), actual);
        }

        [TestMethod]
        public void ComputeOperation_Test3()
        {
            Rule r = new Rule("NONE # Height # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "1.72");
            known.Add("Height", "1.72");
            known.Add("Weight", "75");
            var actual = r.ComputeOperationWith(known);
            Assert.AreEqual("NaN", actual);
        }

        [TestMethod]
        public void ComputeOperation_Test4()
        {
            Rule r = new Rule("NONE # Gender, Height, Weight # BMI # Weight/(Height*Height)");
            Dictionary<string, string> known = new Dictionary<string, string>();
            known.Add("BodyFat", "1.72");
            known.Add("Height", "1.72");
            known.Add("Weight", "75");
            var actual = r.ComputeOperationWith(known);
            Assert.AreEqual("NaN", actual);
        }


    }
}
