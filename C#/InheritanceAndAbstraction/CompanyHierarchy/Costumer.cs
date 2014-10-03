using System;
using System.Text;

namespace CompanyHierarchy
{
    class Costumer : Person, ICostumerInterface
    {
        private decimal totalAmountOfMoney;

        public Costumer(string firstName,string lastName,int id,decimal totalAmountOfMoney) : base(firstName,lastName,id)
        {
            this.TotalAmountOfMoney = totalAmountOfMoney;
        }

        public decimal TotalAmountOfMoney
        {
            get { return this.totalAmountOfMoney; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("total amount of money cannot be less than 0");
                }
                this.totalAmountOfMoney = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Costumer:");
            sb.AppendLine("First Name: " + this.FirstName);
            sb.AppendLine("Last Name: " + this.LastName);
            sb.AppendLine("ID: " + this.ID);
            sb.AppendLine("Total amount of money: " + this.TotalAmountOfMoney);
            return sb.ToString();
        }
    }
}
