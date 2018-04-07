using System.Runtime.Serialization;

namespace ClassLibrary
{
    [DataContract]
    public class Group
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
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
