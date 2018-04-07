using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class CSV : IO
    {
        public Student[] load(string fileName)
        {
            List<Student> students = new List<Student>();

            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] str = sr.ReadLine().Split(',');
                            students.Add(new Student(str[0], str[1], Convert.ToInt32(str[2]), str[3], Convert.ToInt32(str[4])));
                        }
                    }
                }
                return students.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void save(string fileName, Student[] students)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.CreateNew))
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        foreach (Student std in students)
                        {
                            sw.WriteLine(std.firstName + "," + std.lastName + "," + std.age + "," + std.group.name + "," + std.group.course);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
