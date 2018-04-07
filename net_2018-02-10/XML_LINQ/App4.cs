using System;
using System.Xml;
using System.Xml.Linq;

namespace XML_LINQ
{
    class App4
    {
        public static void XML_DOM()
        {
            // API-интерфейс XML DOM
            XmlElement xmlEmployee;//Employee
            XmlAttribute xmlEmployeeType; //EmployeeType
            XmlElement xmlFirstName;
            XmlElement xmlLastName;
            // Создаём документ XML.
            XmlDocument xmlDoc = new XmlDocument();
            // Создаём корневой элемент и добавляем его в документ.
            XmlElement xmlEmployees = xmlDoc.CreateElement("Employees");
            xmlDoc.AppendChild(xmlEmployees);
            // Создаём список участников
            xmlEmployee = xmlDoc.CreateElement("Employee");
            xmlEmployeeType = xmlDoc.CreateAttribute("type");
            xmlEmployeeType.InnerText = "Programmer";
            xmlEmployee.Attributes.Append(xmlEmployeeType);
            xmlFirstName = xmlDoc.CreateElement("FirstName");
            xmlFirstName.InnerText = "Alex";
            xmlEmployee.AppendChild(xmlFirstName);
            xmlLastName = xmlDoc.CreateElement("LastName");
            xmlLastName.InnerText = "Erohin";
            xmlEmployee.AppendChild(xmlLastName);
            xmlEmployees.AppendChild(xmlEmployee);
            // Создаём еще одного участника
            xmlEmployee = xmlDoc.CreateElement("Employee");
            xmlEmployeeType = xmlDoc.CreateAttribute("type");
            xmlEmployeeType.InnerText = "Editor";
            xmlEmployee.Attributes.Append(xmlEmployeeType);
            xmlFirstName = xmlDoc.CreateElement("FirstName");
            xmlFirstName.InnerText = "Elena";
            xmlEmployee.AppendChild(xmlFirstName);
            xmlLastName = xmlDoc.CreateElement("LastName");
            xmlLastName.InnerText = "Volkova";
            xmlEmployee.AppendChild(xmlLastName);
            xmlEmployees.AppendChild(xmlEmployee);
            // Выводим на консоль
            xmlDoc.Save(Console.Out);
        }

        public static void XML_LINQ()
        {
            // API-интерфейс LINQ to XML
            XElement xEmployees =
            new XElement("Employees",
            new XElement("Employee",
            new XAttribute("type", "Programmer"),
            new XElement("FirstName", "Alex"),
            new XElement("LastName", "Erohin")),
            new XElement("Employee",
            new XAttribute("type", "Editor"),
            new XElement("FirstName", "Elena"),
            new XElement("LastName", "Volkova")));
           Console.WriteLine(xEmployees);
        }
        static void Main(string[] args)
        {
            XML_LINQ();
            Console.WriteLine("------------");
            XML_DOM();
            Console.Read();
        }
    }
}
