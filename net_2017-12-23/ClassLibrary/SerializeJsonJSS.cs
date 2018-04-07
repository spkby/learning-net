using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace ClassLibrary
{
    class SerializeJsonJSS : IO
    {
        public Student[] load(string fileName)
        {
            Student[] students = null;

            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string tmp = "";
                        while (!sr.EndOfStream)
                        {
                            tmp += sr.ReadLine();
                        }
                        List<Student> result = serializer.Deserialize<List<Student>>(tmp);
                        students = result.ToArray();
                    }
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
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    string serializedResult = serializer.Serialize(students);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(serializedResult);
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

