using System;
using System.Collections.Generic;

namespace ClassLibrary3
{
    public class Examinations
    {
        List<Exam> exams = new List<Exam>();
        List<Student> students = new List<Student>();
        List<Subject> subjects = new List<Subject>();

        public Examinations()
        {
            Init();
        }

        void Init()
        {
            students.Add(new Student("Иван", "Иванов", 20, "ПО24", 2));
            students.Add(new Student("Петр", "Петров", 21, "ПО33", 3));
            students.Add(new Student("Андрей", "Сидоров", 23, "ПО21", 2));
            students.Add(new Student("Олег", "Бураков", 32, "ПО13", 1));
            students.Add(new Student("Елена", "Прекрасная", 25, "ПО24", 2));

            subjects.Add(new Subject("Философия", "Кант"));
            subjects.Add(new Subject("Химия", "Менделев"));
            subjects.Add(new Subject("Физика", "Ньютон"));
            subjects.Add(new Subject("Литература", "Толстой"));
            subjects.Add(new Subject("Математика", "Пифагор"));

            Student stud = null;
            Subject subj = null;


                DateTime[] dates = new DateTime[5];
                dates[0] = Convert.ToDateTime("2009-05-01");
                dates[1] = Convert.ToDateTime("2009-05-03");
                dates[2] = Convert.ToDateTime("2009-05-05");
                dates[3] = Convert.ToDateTime("2009-05-08");
                dates[4] = Convert.ToDateTime("2009-05-11");


            for (int i = 0; i < students.Count; i++)
            {
                stud = students[i];
                for (int j = 0; j < subjects.Count; j++)
                {
                    subj = subjects[j];
                    exams.Add(new Exam(stud, subj, dates[j], j+1));
                }
            }          
        }

       public Exam[] GetExams()
        {
            return exams.ToArray();
        }


        public Exam[] GetReport(Student student)
        {
            List<Exam> tmp = new List<Exam>();
            foreach (Exam item in exams)
            {
                if (item.student.Equals(student))
                {
                    tmp.Add(item);
                }
            }

            return tmp.ToArray();
        }


        public Exam[] GetReport(DateTime date)
        {
            List<Exam> tmp = new List<Exam>();
            foreach (Exam item in exams)
            {
                if (item.date == date)
                {
                    tmp.Add(item);
                }
            }
            return tmp.ToArray();
        }

        public Exam[] GetReport(int point)
        {
            List<Exam> tmp = new List<Exam>();
            foreach (Exam item in exams)
            {
                if (item.point < point)
                {
                    tmp.Add(item);
                }
            }
            return tmp.ToArray();
        }

        public Exam[] GetReport(Subject subject)
        {
            List<Exam> tmp = new List<Exam>();
            foreach (Exam item in exams)
            {
                if (item.subject.Equals(subject))
                {
                    tmp.Add(item);
                }
            }
            return tmp.ToArray();
        }
    }
}
