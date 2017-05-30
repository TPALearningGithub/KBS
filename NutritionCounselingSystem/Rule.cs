using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicExpresso;
using System.Windows.Forms;

namespace NutritionCounselingSystem
{
    public class Rule
    {
        private string _condition = string.Empty;
        private List<string> _LHS = new List<string>();
        private string _RHS = string.Empty;
        private string _operation = string.Empty;

        public string GetRHS()
        {
            return _RHS;
        }

        public Rule(string rule)
        {
            var part = rule.Split(Constants.SplitedToken).ToList();
            if (part.Count < 4) return;
            _condition = part.First().Trim();
            _LHS = part[1].Trim().Split(',').Select(x => x.Trim()).ToList(); ;
            _RHS = part[2].Trim();
            _operation = part.Last().Trim();
        }

        public override string ToString()
        {
            string rule = string.Empty;
            string lhs = string.Empty;
            foreach (var item in _LHS)
            {
                lhs += item + " ";
            }
            rule += _condition + " || " + lhs + "-> " + _RHS + " = " + _operation; 
            return rule;
        }

        public bool LHSIsSubsetOf(Dictionary<string, string> known)
        {
            var names = known.Select(x => x.Key);
            return !_LHS.Except(names).Any();
        }

        public bool CheckConditionWith(Dictionary<string, string> known)
        {
            if (_condition == Constants.NoneCondition)
            {
                return true;
            }
            var clone = _condition;
            foreach (var name in _LHS)
            {
                string value = string.Empty;
                try
                {
                    value = known[name];
                }
                catch 
                {
                    return false;
                }
                // if value of this attribute is a number.
                if (double.TryParse(value, out double nothing))
                    clone = clone.Replace(name, value);
                else // value is a string.
                    clone = clone.Replace(name, "\"" + value + "\"");
            }
            try
            {
                return new Interpreter().Eval<bool>(clone);
            }
            catch
            {
                MessageBox.Show("Can NOT Find attribute(in condition) in LHS. Please check rule: \n" + ToString());
                return false;
            }
        }

        public bool CanBeUsedWith(Dictionary<string, string> known)
        {
            return !IsEmpty()&&!known.ContainsKey(_RHS) && LHSIsSubsetOf(known) && CheckConditionWith(known);
        }

        public string ComputeOperationWith(Dictionary<string, string> known)
        {
            if (_operation.StartsWith("_"))
            {
                return _operation.Remove(0, 1);
            }
            string clone = _operation;
            foreach (var name in _LHS)
            {
                string value = string.Empty;
                try
                {
                    value = known[name];
                }
                catch
                {
                    MessageBox.Show(name + " isn't in known set.\n");
                    return Constants.NaN;
                }
                clone = clone.Replace(name, value);
            }
            try
            {
                return new Interpreter().Eval<double>(clone).ToString();
            }
            catch
            {
                MessageBox.Show("Can't Compute the operations of this rule:" + ToString() + "\n");
                return Constants.NaN;
            }
        }

        public bool IsEmpty()
        {
            return !_LHS.Any() && !_RHS.Any() && string.IsNullOrEmpty(_condition);
        }
    }
}
