using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : People
    {
        private List<Disciplines> disciplines;

        public List<Disciplines> Disciplines { get; set; }

        public Teacher(string name, List<Disciplines> disciplines, string details = null) :
            base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Teacher name: " + this.Name);
            sb.AppendLine("Disciplines: ");
            sb.AppendLine("" + string.Join("", this.Disciplines));
            if (this.Details != null)
            {
                sb.AppendLine("Details: " + this.Details);
            }
            return sb.ToString();
        }
    }
}
