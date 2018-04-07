using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Bin : IO
    {
        public Student[] load(string fileName)
        {
            List<Student> students = new List<Student>();

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {                    
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        try
                        {
                            students.Add(new Student(reader.ReadString(), reader.ReadString(), reader.ReadInt32(), reader.ReadString(), reader.ReadInt32()));
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }
            return students.ToArray();

        }

        public void save(string fileName, Student[] students)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.CreateNew))
                {
                    using (BinaryWriter writer = new BinaryWriter(fs))
                    {
                        foreach (Student std in students)
                        {
                            //writer.Write(1);
                            writer.Write(std.firstName);
                            writer.Write(std.lastName);
                            writer.Write(std.age);
                            writer.Write(std.group.name);
                            writer.Write(std.group.course);
                        }
                        //writer.Write(0);
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
