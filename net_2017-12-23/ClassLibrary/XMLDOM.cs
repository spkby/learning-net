using System;
using System.Collections.Generic;
using System.Xml;

namespace ClassLibrary
{
    class XMLDOM : IO
    {
        public Student[] load(string fileName)
        {
            List<Student> students = new List<Student>();

            try
            {
                Group tmpGroup = null;
                Student tmpStud = null;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(fileName);
                XmlElement root = xmldoc.DocumentElement;
                foreach (XmlElement node in root)
                {
                    tmpStud = new Student();


                    foreach (XmlNode studentNode in node.ChildNodes)
                    {
                        if (studentNode.Name == "FirstName") tmpStud.firstName = studentNode.InnerText;
                        if (studentNode.Name == "LastName") tmpStud.lastName = studentNode.InnerText;
                        if (studentNode.Name == "Age") tmpStud.age = Convert.ToInt32(studentNode.InnerText);


                        if (studentNode.Name == "Group")
                        {
                            tmpGroup = new Group();
                            foreach (XmlNode groupNode in studentNode.ChildNodes)
                            {
                                if (groupNode.Name == "Name")
                                    tmpGroup.name = groupNode.InnerText;

                                if (groupNode.Name == "Course")
                                    tmpGroup.course = Convert.ToInt32(groupNode.InnerText);
                            }
                            tmpStud.group = tmpGroup;
                        }
                        
                    }
                    students.Add(tmpStud);
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
                XmlDocument xDoc = new XmlDocument();
                XmlDeclaration xmldecl;
                xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
               
                xDoc.LoadXml("<Students></Students>");

                XmlElement xRoot = xDoc.DocumentElement;
                xDoc.InsertBefore(xmldecl, xRoot);


                foreach (var stud in students)
                {
                    // создаем новый элемент user
                    XmlElement studElem = xDoc.CreateElement("Student");

                    // создаем элементы company и age
                    XmlElement firstNameElem = xDoc.CreateElement("FirstName");
                    XmlElement lastNameElem = xDoc.CreateElement("LastName");
                    XmlElement ageElem = xDoc.CreateElement("Age");

                    XmlElement groupElem = xDoc.CreateElement("Group");
                    XmlElement groupNameElem = xDoc.CreateElement("Name");
                    XmlElement groupCourseElem = xDoc.CreateElement("Course");

                    // создаем текстовые значения для элементов и атрибута
                    XmlText firstNameText = xDoc.CreateTextNode(stud.firstName);
                    XmlText lastNameText = xDoc.CreateTextNode(stud.lastName);                   
                    XmlText ageText = xDoc.CreateTextNode(stud.age.ToString());

                    XmlText groupNameText = xDoc.CreateTextNode(stud.group.name);
                    XmlText groupCourseText = xDoc.CreateTextNode(stud.group.course.ToString());


                    //добавляем узлы
                    firstNameElem.AppendChild(firstNameText);
                    lastNameElem.AppendChild(lastNameText);
                    ageElem.AppendChild(ageText);

                    groupNameElem.AppendChild(groupNameText);
                    groupCourseElem.AppendChild(groupCourseText);

                    groupElem.AppendChild(groupNameElem);
                    groupElem.AppendChild(groupCourseElem);

                    studElem.AppendChild(firstNameElem);
                    studElem.AppendChild(lastNameElem);
                    studElem.AppendChild(ageElem);
                    studElem.AppendChild(groupElem);

                    xRoot.AppendChild(studElem);
                }

                xDoc.Save(fileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

