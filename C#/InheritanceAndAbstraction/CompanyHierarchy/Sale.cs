using System;
using System.Text;

namespace CompanyHierarchy
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Product name: " + this.ProductName);
            sb.AppendLine("Date: " + this.Date);
            sb.AppendLine("Price: " + this.Price);
            return sb.ToString();
        }
    }
}
