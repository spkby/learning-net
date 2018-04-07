using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    class LinqXML : IO
    {
        public Student[] load(string fileName)
        {
            List<Student> students = new List<Student>();

            StringBuilder result = new StringBuilder();

            //Load xml
            try
            {
                XDocument xdoc = XDocument.Load(fileName);
                var studs = from stud in xdoc.Element("Students").Elements("Student")
                            select new Student
                            {
                                firstName = stud.Element("FirstName").Value,
                                lastName = stud.Element("LastName").Value,
                                age = Convert.ToInt32(stud.Element("Age").Value),
                                /*group = stud.Elements("group")
                                            .Select(group => new Group()
                                            {
                                                name = group.Element("name").Value,
                                                course = Convert.ToInt32(group.Element("course").Value)
                                            });*/
                            };
                students = studs.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return students.ToArray();
        }

        public void save(string fileName, Student[] students)
        {
            try
            {
                XElement xRoot = new XElement("Students");

                foreach (var stud in students)
                {

                    XElement element = new XElement("Student",
            new XElement("FirstName", stud.firstName),
            new XElement("LastName", stud.lastName),
            new XElement("Age", stud.age),
            new XElement("Group",
            new XElement("Name", stud.group.name),
            new XElement("Course", stud.group.course)
            ));
                    xRoot.Add(element);
                }

                XDocument xDoc = new XDocument(xRoot);

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    xDoc.Save(sw);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

