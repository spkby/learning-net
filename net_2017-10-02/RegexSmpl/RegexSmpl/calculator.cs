using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexSmpl
{
    public class Calculator
    {
        string regNumbers = "";
        string regOperators = "";
        int[] numbers;
        string[] operations;

        public Calculator()
        {
            regNumbers = @"[-+]?\d+";
            regOperators = @"[-+*/]";
        }

        void parseNumbers(string inputStr)
        {
            Regex theReg = new Regex(regNumbers);
            MatchCollection didgits = theReg.Matches(inputStr);

            numbers = new int[didgits.Count];

            int i = 0;

            foreach (Match item in didgits)
            {
                numbers[i] = Convert.ToInt32(item.Value);
                i++;
            }        }

        void parseOperators(string inputStr)
        {
            Regex theReg = new Regex(regOperators);
            MatchCollection oper = theReg.Matches(inputStr);

            operations = new string[oper.Count];

            int i = 0;

            foreach (Match item in oper)
            {
                operations[i++] = item.Value;
            }        }

        public int calc(string inputStr)
        {
            int op1 = 0;
            int op2 = 0;
            string curOper = "";

            parseNumbers(inputStr);
            parseOperators(inputStr);

            op1 = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                curOper = operations[i - 1];
                op2 = numbers[i];
                switch (curOper)
                {
                    case "+":
                        op1 += op2;
                        break;
                    case "-":
                        op1 -= op2;
                        break;
                    case "*":
                        op1 *= op2;
                        break;
                    case "/":
                        op1 /= op2;
                        break;
                }
             
            }

            return op1;
        }
    }
}
