namespace ClassLibrary3
{
    public class Student
    {
        public string lastName { get; set; }
        public string firstName { get; set; }

        public int age { get; set; }

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

        public override string ToString()
        {
            return firstName + " " + lastName + " (возраст: "+age.ToString()+ ")\tГруппа: " + group.name + "  курс: " + group.course;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Student);
        }

        public bool Equals(Student obj)
        {
            return obj != null && obj.firstName == this.firstName && obj.lastName == this.lastName
                && obj.age == this.age && obj.group.name == this.group.name && obj.group.course == this.group.course;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
