using System.Text;

namespace School
{
    public class Student : People
    {
        private int classNumber;

        public Student(string name, int classNumber, string details = null)
            : base(name, details)
        {
            this.ClassNumber = classNumber;
        }
        public int ClassNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Student name: " + this.Name + ", Class number: " + this.ClassNumber);
            if (this.Details != null)
            {
                sb.AppendLine("Details: " + this.Details);
            }
            return sb.ToString();
        }
    }
}
