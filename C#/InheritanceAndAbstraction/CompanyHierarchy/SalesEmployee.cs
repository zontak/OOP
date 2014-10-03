using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class SalesEmployee : RegularEmployee, ISalesEmployeeInterface
    {
        private List<Sale> sales;

        public SalesEmployee(List<Sale> sales )
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get { return this.sales; }
            set { this.sales = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sales Employee:");
            sb.AppendLine("Sales: " + string.Join("",this.Sales));
            return sb.ToString();
        }
    }
}
