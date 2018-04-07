using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class SerializeXML : IO
    {
        public Student[] load(string fileName)
        {
            Student[] students = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Student[]));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    students = (Student[])serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return students;
        }

        public void save(string fileName, Student[] students)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(fileName))
                {
                    XmlSerializer s = new XmlSerializer(typeof(Student[]));
                    s.Serialize(tw, students);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
