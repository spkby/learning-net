namespace ClassLibrary3
{
    public class Subject
    {
        public string name { get; set; }
        public string teacher { get; set; }

        public Subject(string name, string teacher)
        {
            this.name = name;
            this.teacher = teacher;
        }

        public override string ToString()
        {
            return name + "\t" + teacher;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Subject);
        }

        public bool Equals(Subject obj)
        {
            return obj != null && obj.name == this.name && obj.teacher == this.teacher;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
