using System;

namespace OOP_RATIONAL
{
    public class Rational
    {
        
        private int _numerator;
        private int _denominator;

        
        public int Numerator
        {
            get { return _numerator; }
            set
            {
                _numerator = value;
                Simplify(); 
            }
        }

        
        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0) 
                {
                    throw new DivideByZeroException("Denominator should not be = 0");
                }
                _denominator = value;
                Simplify(); 
            }
        }

        
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0) 
            {
                throw new DivideByZeroException("Denominator should not be = 0");
            }

            _numerator = numerator;
            _denominator = denominator;
            Simplify(); 
        }

        
        public Rational(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
            Simplify();
        }

        
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        
        private void Simplify()
        {
            
            if (_denominator < 0)
            {
                _numerator *= -1;
                _denominator *= -1;
            }

            
            int gcd = GCD(Math.Abs(_numerator), Math.Abs(_denominator));

            
            if (gcd > 0)
            {
                _numerator /= gcd;
                _denominator /= gcd;
            }
        }

        
        public override string ToString()
        {
            return $"Rational: {Numerator} / {Denominator}";
        }

        
        

        public static Rational operator +(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Denominator;
            int newNumerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Denominator;
            int newNumerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Denominator;
            int newNumerator = r1.Numerator * r2.Numerator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Numerator;
            int newNumerator = r1.Numerator * r2.Denominator;
            return new Rational(newNumerator, newDenominator);
        }

        

        public static bool operator >(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator;
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }

        public static bool operator >=(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator >= r2.Numerator * r1.Denominator;
        }

        public static bool operator <=(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator <= r2.Numerator * r1.Denominator;
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            if (ReferenceEquals(r1, null) && ReferenceEquals(r2, null)) return true;
            if (ReferenceEquals(r1, null) || ReferenceEquals(r2, null)) return false;
            
            return r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }

        
        public override bool Equals(object obj)
        {
            if (obj is Rational other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }
    }
}