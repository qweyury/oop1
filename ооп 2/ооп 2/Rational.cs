using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп_2
{
    public class Rational
    {
        private int numerator;
        private int denominator;

        public int Numerator => numerator;
        public int Denominator => denominator;


        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator can not be o.");

            int gcd = GCD(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;


            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
        }


        public override string ToString()
        {
            if (denominator == 1)
                return numerator.ToString();
            return $"{numerator}/{denominator}";
        }


        public static Rational operator +(Rational a, Rational b)
        {
            int num = a.numerator * b.denominator + b.numerator * a.denominator;
            int denom = a.denominator * b.denominator;
            return new Rational(num, denom);
        }


        public static Rational operator -(Rational a, Rational b)
        {
            int num = a.numerator * b.denominator - b.numerator * a.denominator;
            int denom = a.denominator * b.denominator;
            return new Rational(num, denom);
        }


        public static Rational operator *(Rational a, Rational b)
        {
            int num = a.numerator * b.numerator;
            int denom = a.denominator * b.denominator;
            return new Rational(num, denom);
        }


        public static Rational operator /(Rational a, Rational b)
        {
            if (b.numerator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            int num = a.numerator * b.denominator;
            int denom = a.denominator * b.numerator;
            return new Rational(num, denom);
        }


        public static Rational operator -(Rational a)
        {
            return new Rational(-a.numerator, a.denominator);
        }


        public static bool operator ==(Rational a, Rational b)
        {
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }


        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }


        public static bool operator <(Rational a, Rational b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }


        public static bool operator <=(Rational a, Rational b)
        {
            return a.numerator * b.denominator <= b.numerator * a.denominator;
        }


        public static bool operator >(Rational a, Rational b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }


        public static bool operator >=(Rational a, Rational b)
        {
            return a.numerator * b.denominator >= b.numerator * a.denominator;
        }


        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override bool Equals(object obj)
        {
            return obj is Rational rational && this == rational;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
    }
}
