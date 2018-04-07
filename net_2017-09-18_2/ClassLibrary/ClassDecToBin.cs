using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClassDecToBin
    {
        string digitDecToBin(char digit)
        {
            switch (digit)
            {
                case '0':
                    return "0000";
                case '1':
                    return "0001";
                case '2':
                    return "0010";
                case '3':
                    return "0011";
                case '4':
                    return "0100";
                case '5':
                    return "0101";
                case '6':
                    return "0110";
                case '7':
                    return "0111";
                case '8':
                    return "1000";
                case '9':
                    return "1001";
                default:
                    return "";
            }            
        }

        public string digitsDecToBin(string digits)
        {
            string strOut = "";
            foreach (char digit in digits)
            {
                string str = digitDecToBin(digit);
                if (str == "") continue;
                else strOut += str + " "; 
            }
            return strOut;
        }

    }
}
