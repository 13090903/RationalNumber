using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RationalNumberApp.Model
{
    public class RationalNumber
    {
        private long _numerator;
        private long _denominator;
        public RationalNumber(long numerator, long denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
            Norm();
        }

        public void Norm()
        {
            int sign1 = _numerator < 0 ? -1 : 1;
            int sign2 = _denominator < 0 ? -1 : 1;
            int sign = sign1 * sign2;
            long g = Gcd(_numerator, _denominator);
            _numerator = sign * Math.Abs(_numerator / g);
            _denominator = Math.Abs(_denominator / g);
        }

        private static long Gcd(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return Gcd(b, a % b);
        }

        override
        public string ToString()
        {
            return _numerator + " / " + _denominator;
        }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber res = new RationalNumber(r1._numerator * r2._denominator + r2._numerator * r1._denominator,
                r1._denominator * r2._denominator);
            return res;
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber res = new RationalNumber(r1._numerator * r2._denominator - r2._numerator * r1._denominator,
                r1._denominator * r2._denominator);
            return res;
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber res = new(r1._numerator * r2._numerator,
                r1._denominator * r2._denominator);
            return res;
        }
        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber res = new(r1._numerator * r2._denominator,
                r1._denominator * r2._numerator);
            return res;
        }

        public static string Compare(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber res = r1 - r2;
            int sign1 = res._numerator < 0 ? -1 : 1;
            int sign2 = res._denominator < 0 ? -1 : 1;
            int sign = sign1 * sign2;
            if (res._numerator == 0) {
                return "Числа равны";
            }
            if (sign < 0) {
                return "Второе число больше";
            }
            return "Первое число больше";
        }

        public static double AsDouble(RationalNumber r1, int decPl)
        {
            double res = 1.0*r1._numerator / r1._denominator;
            res = Math.Round(res * Math.Pow(10, decPl))/ Math.Pow(10, decPl);
            return res;
        }

        public static RationalNumber AsDecimal(double num, int decPl)
        {
            double res = num;
            res = Math.Round(res * Math.Pow(10, decPl)) / Math.Pow(10, decPl);
            RationalNumber result = new((long)(res * Math.Pow(10, decPl)), (long)Math.Pow(10, decPl));
            return result;
        }
    }
}
