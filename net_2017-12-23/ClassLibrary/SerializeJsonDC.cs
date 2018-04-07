using System;
using System.IO;
using System.Runtime.Serialization.Json;


namespace ClassLibrary
{
    class SerializeJsonDC : IO
    {
        public Student[] load(string fileName)
        {
            Student[] students = null;
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Student[]));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    students = (Student[])jsonFormatter.ReadObject(fs);
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
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Student[]));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, students);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
