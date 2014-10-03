using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Disciplines
    {
        private string name;
        private int numberOfLectures;
        private List<Student> student; 
        private string details;

        public List<Student> Student { get; set; }
        public string Details { get; set; }
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }

        public Disciplines(string name, int numberOfLectures, List<Student> student, string details = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Details = details;
            this.Student = student;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("" + this.Name);
            sb.Append("" + string.Join("", this.Student));
            if (this.Details != null)
            {
                sb.AppendLine("Details: " + this.Details);
            }
            return sb.ToString();
        }
    }
}
