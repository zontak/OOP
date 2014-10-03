using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculator
    {
        private string interest;
        private int money;
        private int years;

        public delegate void CalculateInterest<T>(T str);

        public string Interest
        {
            get { return this.interest; }
            set { this.interest = value; } 
        }

        public int Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public int Years
        {
            get { return this.years; }
            set { this.years = value; }
        }

        public InterestCalculator()
        {
            this.Money = money;
            this.Years = years;
            this.Interest = interest;
        }


    }
}
