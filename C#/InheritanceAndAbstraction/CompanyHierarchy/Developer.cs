using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class Developer : RegularEmployee, IDeveloperInterface
    {
        private List<Project> projects;

        public Developer(List<Project> projects )
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Developer: ");
            sb.AppendLine("" + string.Join("", this.Projects));
            return sb.ToString();
        }
    }
}
