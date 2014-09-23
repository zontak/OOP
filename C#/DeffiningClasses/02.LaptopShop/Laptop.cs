using System;
using System.Text;

namespace _02.LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string hdd;
        private string graphicsCard;
        private Battery battery;
        private string screen;
        private decimal price;

        public Laptop(
            string model, decimal price, string manufacturer = null,
            string processor = null, string RAM = null, string graphisCard = null,
            string screen = null, string HDD = null, Battery battery = null)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphisCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid parameter for model");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                this.processor = value;
            }
        }
        public string GraphisCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                this.graphicsCard = value;
            }
        }
        public string RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }
        public string HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                this.hdd = value;
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
                if(value < 1)
                {
                    throw new ArgumentException("the price must be greater than 2 lv");
                }
                this.price = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                this.screen = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Model is: " + this.model);
            if (this.manufacturer != null)
            {
                result.AppendLine("Manufacturer is: " + this.manufacturer);
            }
            if (this.processor != null)
            {
                result.AppendLine("Processor is: " + this.processor);
            }
            if(this.ram != null)
            {
                result.AppendLine("Ram is: " + this.ram);
            }
            if(this.hdd != null)
            {
                result.AppendLine("Hdd is: " + this.hdd);
            }
            result.AppendLine("Price is: " + this.price);
            if(this.screen != null)
            {
                result.AppendLine("Screen is: " + this.screen);
            }
            if(this.graphicsCard != null)
            {
                result.AppendLine("Graphics card is: " + this.graphicsCard);
            }
            if(this.battery != null)
            {
                result.AppendLine("" + this.battery);
            }
            return result.ToString();
        }
    }
}
