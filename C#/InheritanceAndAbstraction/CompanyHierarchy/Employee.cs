using System;
using System.Text;

namespace CompanyHierarchy
{
    public class Employee : Person, IEmployeeInterface
    {
        private decimal salary;
        private DepartmentEmployee department;

        public Employee(string firstName,string lastName, int id, decimal salary, DepartmentEmployee department) :
            base(firstName,lastName,id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be less than 0");
                }
                this.salary = value;
            }
        }

        public DepartmentEmployee Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First Name: " + this.FirstName);
            sb.AppendLine("Last Name: " + this.LastName);
            sb.AppendLine("ID: " + this.ID);
            sb.AppendLine("Salary: " + this.Salary);
            sb.AppendLine("Department: " + this.Department);
            return sb.ToString();
        }
    }
}
