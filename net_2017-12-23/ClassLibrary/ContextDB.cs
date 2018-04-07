using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class ContextDB
    {
        List<Student> students = new List<Student>();
        public int curStudent {get;set;}        

        public void Initialize()
        {
            Add("Иван","Иванов",20,"ПО24",2);
            Add("Петр", "Петров", 21, "ПО33", 3);
            Add("Андрей", "Сидоров", 23, "ПО21", 2);
            Add("Олег", "Бураков", 32, "ПО13", 1);
            Add("Елена", "Прекрасная", 25, "ПО24", 2);
        }

        public ContextDB()
        {
            curStudent = -1;
            Initialize();
        }

        public void Add(string firstName, string lastName, int age, string nameGroup, int courseGroup)
        {
            students.Add(new Student(firstName, lastName, age, nameGroup, courseGroup));
            curStudent = students.Count - 1;
        }

        public void Edit(string firstName, string lastName, int age, string nameGroup, int courseGroup)
        {
            if (curStudent == -1) return;
            students[curStudent].firstName = firstName;
            students[curStudent].lastName = lastName;
            students[curStudent].age = age;
            students[curStudent].group.name = nameGroup;
            students[curStudent].group.course = courseGroup;
        }

        public void Edit(Student s)
        {
            if (curStudent == -1) return;
            students[curStudent] = s;
        }

        void Remove(Student stdnt)
        {
            students.Remove(stdnt);
            if (students.Count == 0)
            {
                curStudent = -1;
                return;
            }
            if (curStudent == students.Count)
            {
                curStudent--;
            }
        }

        public void Remove()
        {
            if (curStudent == -1) return;
            Student s = students[curStudent];
            Remove(s);
        }


        public void LoadFrom(byte type, string fileName)
        {
            IO file = null;
            switch (type)
            {
                case 1:
                    file = new CSV();
                    break;
                case 2:
                    file = new Bin();
                    break;
                case 3:
                    file = new XMLSax();
                    break;
                case 4:
                    file = new XMLDOM();
                    break;
                case 5:
                    file = new SerializeXML();
                    break;
                case 6:
                    file = new LinqXML();
                    break;
                case 7:
                    file = new SerializeJsonDC();
                    break;
                case 8:
                    file = new SerializeJsonJSS();
                    break;
            }

            try
            {
                Student[] std = file.load(fileName);
                students.Clear();
                foreach (Student stud in std)
                {
                    students.Add(stud);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SaveTo(byte type, string fileName)
        {
            IO file = null;
            switch (type)
            {
                case 1:
                    file = new CSV();
                    break;
                case 2:
                    file = new Bin();
                    break;
                case 3:
                    file = new XMLSax();
                    break;
                case 4:
                    file = new XMLDOM();
                    break;
                case 5:
                    file = new SerializeXML();
                    break;
                case 6:
                    file = new LinqXML();
                    break;
                case 7:
                    file = new SerializeJsonDC();
                    break;
                case 8:
                    file = new SerializeJsonJSS();
                    break;
            }
            try
            {
                file.save(fileName, students.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Next()
        {
            if (students.Count == 0) return;
            if (curStudent + 1 == students.Count) return;
            curStudent++;
        }
        public void Prev()
        {
            if (students.Count == 0) return;
            if (curStudent == 0) return;
            curStudent--;
        }

        public Student GetCurStudent()
        {
            if (curStudent == -1 || students.Count == 0) return null;
            return students[curStudent];
        }

        public Student[] GetStudents()
        {
            return students.ToArray();
        }

        public void SetCurStudent(Student s)
        {
            curStudent = students.IndexOf(s);
        }

    }
}
