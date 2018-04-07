using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary
{
    class XMLSax : IO
    {
        public Student[] load(string fileName)
        {

            Student tmpStud = null;
            Group tmpGroup = null;

            List<Student> students = new List<Student>();

            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (XmlTextReader reader = new XmlTextReader(fs))
                    {
                        while (reader.Read())
                        {
                            switch (reader.NodeType)
                            {
                                case XmlNodeType.Element:
                                    switch (reader.Name)
                                    {
                                        case "Student":
                                            tmpStud = new Student();
                                            break;
                                        case "FirstName":
                                            reader.Read();
                                            tmpStud.firstName = reader.Value;
                                            break;
                                        case "LastName":
                                            reader.Read();
                                            tmpStud.lastName = reader.Value;
                                            break;
                                        case "Age":
                                            reader.Read();
                                            tmpStud.age = Convert.ToInt32(reader.Value);
                                            break;
                                        case "Group":
                                            tmpGroup = new Group();
                                            break;
                                        case "Name":
                                            reader.Read();
                                            tmpGroup.name = reader.Value;
                                            break;
                                        case "Course":
                                            reader.Read();
                                            tmpGroup.course = Convert.ToInt32(reader.Value);
                                            break;
                                    }
                                    break;
                                /*                    case XmlNodeType.Text: // Вывести текст в каждом элементе.
                                                        Console.WriteLine(reader.Value);
                                                        break;*/
                                case XmlNodeType.EndElement:
                                    switch (reader.Name)
                                    {
                                        case "Student":
                                            students.Add(tmpStud);
                                            break;
                                        case "Group":
                                            tmpStud.group = tmpGroup;
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                }
                return students.ToArray();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void save(string fileName, Student[] students)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    using (XmlTextWriter xml = new XmlTextWriter(sw))
                    {
                        xml.WriteStartDocument(); // корневой раздел
                        xml.WriteStartElement("Students");
                        xml.WriteWhitespace("\n");

                        foreach (var element in students)
                        {
                            xml.WriteStartElement("Student");
                            xml.WriteElementString("FirstName", element.firstName);
                            xml.WriteWhitespace("\n ");
                            xml.WriteElementString("LastName", element.lastName);
                            xml.WriteWhitespace("\n ");
                            xml.WriteElementString("Age", element.age.ToString());
                            xml.WriteWhitespace("\n ");
                            xml.WriteStartElement("Group");
                            xml.WriteElementString("Name", element.group.name);
                            xml.WriteWhitespace("\n ");
                            xml.WriteElementString("Course", element.group.course.ToString());
                            xml.WriteWhitespace("\n ");
                            xml.WriteEndElement();
                            xml.WriteWhitespace("\n");
                            xml.WriteEndElement();
                            xml.WriteWhitespace("\n");
                        }
                        xml.WriteEndElement();
                        xml.WriteEndDocument();

                        xml.Flush();
                        sw.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
