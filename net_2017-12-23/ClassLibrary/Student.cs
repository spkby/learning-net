using System;
using System.Runtime.Serialization;

namespace ClassLibrary
{

    [Serializable]
    [DataContract]
    public class Student
    {
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public string firstName { get; set; }

        [DataMember]
        public int age { get; set; }

        [DataMember]
        public Group group { get; set; }

        public Student()
        {
            lastName = "";
            firstName = "";
            age = 0;
            group = null;
        }

        public Student(string firstName, string lastName, int age, string nameGroup, int courseGroup)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            group = new Group(nameGroup, courseGroup);
        }


        public Student(string firstName, string lastName, int age, Group group)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            this.group = group;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " (возраст: "+age.ToString()+ ")\tГруппа: " + group.name + "  курс: " + group.course;
        }

    }
}
