using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Convertor;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            ProgramConverter[] pc = new ProgramConverter[4];

            pc[0] = new ProgramConverter();
            pc[1] = new ProgramConverter();
            pc[2] = new ProgramHelper();
            pc[3] = new ProgramHelper();

            foreach (ProgramConverter item in pc)
            {
                Console.WriteLine(item.ConvertToCSharp("aaa"));
            }


            ProgramHelper ph1 = pc[2] as ProgramHelper;
            ProgramHelper ph2 = pc[0] as ProgramHelper;

            if(ph1 != null) {
                ph1.CodeCheckSyntax(pc[0].ConvertToCSharp("aaa"), pc[2].ConvertToCSharp("aaa"));
                Console.WriteLine("PH");
            }
            else
            {
                Console.WriteLine("no PH");
            }
            if (ph2 != null)
            {
                ph2.CodeCheckSyntax(pc[0].ConvertToCSharp("aaa"), pc[2].ConvertToCSharp("aaa"));
                Console.WriteLine("PH");
            }
            else
            {
                Console.WriteLine("no PH");
            }

            Console.ReadLine();
        }
    }
}
