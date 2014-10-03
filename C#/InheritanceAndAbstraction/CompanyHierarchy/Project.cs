using System;
using System.Text;

namespace CompanyHierarchy
{
    public enum State
    {
        open = 0,
        closed = 1
    }
    public class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public State State { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public string Details { get; set; }
        public string ProjectName { get; set; }

        public Project(string projectName,DateTime projectStartDate,string details,State state )
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Project Name: " + this.ProjectName);
            sb.AppendLine("Project Start Date: " + this.ProjectStartDate);
            sb.AppendLine("Project Details: " + this.Details);
            sb.AppendLine("Project state: " + this.State);
            return sb.ToString();
        }
    }
}
