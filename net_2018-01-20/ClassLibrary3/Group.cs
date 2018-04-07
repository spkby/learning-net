namespace ClassLibrary3
{
    public class Group
    {
        public string name { get; set; }
        public int course { get; set; }

        public Group()
        {
            name = "";
            course = 0;
        }

        public Group (string name, int course)
        {
            this.name = name;
            this.course = course;
        }
    }
}
