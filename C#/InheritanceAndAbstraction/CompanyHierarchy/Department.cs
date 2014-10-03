using System.Text;
namespace CompanyHierarchy
{
    public enum Department
    {
        Production,
        Accounting,
        Sales,
        Marketing
    }

    public class DepartmentEmployee
    {
        private Department enumche;

        public Department Enumche { get; set; }

        public DepartmentEmployee(Department enumche)
        {
            this.Enumche = enumche;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("" + this.Enumche);
            return sb.ToString();
        }
    }

}
