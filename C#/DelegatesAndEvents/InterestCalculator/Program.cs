using System;

namespace DelegatesExam
{
    class InterestCalculator
    {
        private double interest;
        private decimal money;
        private int years;

        public delegate decimal CalculateInterest(decimal money, double interest, int years);

        public decimal paybackValue;

        public double Interest
        {
            get { return this.interest; }
            set { this.interest = value; }
        }

        public decimal Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public int Years
        {
            get { return this.years; }
            set { this.years = value; }
        }

        public InterestCalculator(decimal money, double interest, int years, CalculateInterest calcInterest)
        {
            this.Money = money;
            this.Years = years;
            this.Interest = interest;
            this.paybackValue = calcInterest(this.Money, this.Interest, this.Years);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            InterestCalculator interest = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(interest.paybackValue.ToString("##.####"));

            InterestCalculator interest2 = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine("{0:0.0000}",interest2.paybackValue);
        }

        public static decimal GetSimpleInterest(decimal sum, double interest, int year)
        {
            decimal A = sum * (decimal)(1 + (interest * year / 100));
            return A;
        }

        public static decimal GetCompoundInterest(decimal sum, double interest, int year)
        {
            decimal A = sum * (decimal)Math.Pow((1 + interest / 12 / 100), year * 12);
            return A;
        }


    }
}
