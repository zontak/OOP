using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CompanyHierarchy
{
    public class Manager : Employee, IManagerInterface
    {
        private List<Employee> employees;

        public Manager( string firstName,string lastName,int id,decimal salary, DepartmentEmployee department, List<Employee> employees ) :
            base(firstName,lastName,id,salary,department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Manager:");
            sb.AppendLine("Employe list:");
            sb.AppendLine("" + string.Join("", this.Employees));
            return sb.ToString();
        }
    }
}
