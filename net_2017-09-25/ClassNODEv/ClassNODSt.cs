using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNOD
{
    public class ClassNODSt
    {
        public int NOD(int a, int b)
        {
            if (a == 0) return b;                            
            if (b == 0) return a;                            
            if (a == b) return a;                            
            if (a == 1 || b == 1) return 1;                            
            if ((a % 2) == 0)
                return ((b % 2) == 0) ? NOD(a / 2, b / 2) * 2 : NOD(a / 2, b);                
            else                                     
                return ((b % 2) == 0) ? NOD(a, b / 2) : NOD(b, a > b ? a - b : b - a);       
        }
    }
}
