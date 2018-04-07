using System;

namespace ClassLibrary3
{
    public class Exam
    {
        public Student student { get; }
        public Subject subject { get; }

        public DateTime date { get; }
        public int point { get; }

        public Exam(Student student, Subject subject, DateTime date, int point)
        {
            this.student = student;
            this.subject = subject;
            this.date = date;
            this.point = point;
        }


        public override string ToString()
        {
            return student + "\t" + subject + "\t" + date.ToShortDateString() + "\t" + point; 
        }
    }
}
