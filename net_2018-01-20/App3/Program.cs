using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace App3
{
    class Program
    {
        static Examinations examinations = new Examinations();

        static void Main(string[] args)
        {
            PrintReport(examinations.GetExams());

            PrintLine();

            PrintReport(examinations.GetReport(new Student("Олег", "Бураков", 32, "ПО13", 1)));

            PrintLine();

            PrintReport(examinations.GetReport(Convert.ToDateTime("2009-05-08")));

            PrintLine();

            PrintReport(examinations.GetReport(2));

            PrintLine();

            PrintReport(examinations.GetReport(new Subject("Физика", "Ньютон")));

            

            Console.ReadLine();

        }

        static void PrintReport(Exam[] exams)
        {
            foreach (var item in exams)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintLine()
        {
            Console.WriteLine("______________________________________________________________________" + "\n");
            
        }
    }
}
