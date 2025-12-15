using System;

namespace TASK1
{
    public class Fraction
    {
        private int wholePart;
        private int fractionPart;
        public int WholePart
        {
            get { return wholePart; }
            set { wholePart = value; }
        }

        public int FractionalPart
        {
            get { return fractionPart; }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    fractionPart = value;
                }
                else
                {
                    Console.WriteLine("Warning: Дробная часть должна быть от 0 до 999. Значение не изменено.");
                }
            }
        }

        public Fraction(int whole, int fractional)
        {
            if (fractional >= 1000)
            {
                whole += fractional / 1000;
                fractional = fractional % 1000;
            }

            wholePart = whole;
            fractionPart = fractional;
        }
        private double ToDouble()
        {
            return wholePart + (fractionPart / 1000.0);
        }

        private static Fraction FromDouble(double value)
        {
            int whole = (int)value;

            int fractional = (int)Math.Round((value - whole) * 1000);

            return new Fraction(whole, fractional);
        }


        public static Fraction operator +(Fraction a, Fraction b)
        {
            double sum = a.ToDouble() + b.ToDouble();
            return FromDouble(sum);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            double diff = a.ToDouble() - b.ToDouble();
            return FromDouble(diff);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            double product = a.ToDouble() * b.ToDouble();
            return FromDouble(product);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.ToDouble() == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            double quotient = a.ToDouble() / b.ToDouble();
            return FromDouble(quotient);
        }
        public override string ToString()
        {
            return $"{wholePart}.{fractionPart:D3}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction other)
            {
                return this.wholePart == other.wholePart &&
                       this.fractionPart == other.fractionPart;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(wholePart, fractionPart);
        }
    }
}