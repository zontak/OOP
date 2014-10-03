using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;
        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }
        public long Denominator 
        {
            get
            {
                return this.denominator;
            }
            set 
            { 
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0");
                }
                this.denominator = value;
            }
        }

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long numerator = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            long denomominator = f1.denominator * f2.denominator;
            return new Fraction(numerator, denomominator);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long numerator = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            long denomominator = f1.denominator * f2.denominator;
            return new Fraction(numerator, denomominator);
        }

        public override string ToString()
        {
            return ((decimal)numerator / denominator).ToString();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
