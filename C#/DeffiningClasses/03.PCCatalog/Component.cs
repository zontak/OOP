using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    public abstract class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please set name");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price cannot be less than from zero");
                }
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }
        public override string ToString()
        {
            string componentString = string.Format("Name: {0}, Price: {1}", this.name, this.price);
            if(this.details != null)
            {
                componentString += string.Format(", Details: {0}", this.details);
            }
            return componentString;
        }
    }
}
