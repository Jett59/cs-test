using System.Diagnostics.CodeAnalysis;

namespace app
{
    public readonly struct Fraction
    {
        public readonly long Numerator { get; }
        public readonly long Denominator { get; }

        public Fraction(long numerator, long denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            if (denominator < 0) {
                numerator = -numerator;
                denominator = -denominator;
            }
            Numerator = numerator;
            Denominator = denominator;
        }

public Fraction simplify() {
            long gcd = (long)MathHelper.GCD((ulong)Math.Abs(Numerator), (ulong)Denominator);
            return new Fraction(Numerator / gcd, Denominator / gcd);
        }

        public override string ToString() => $"{Numerator}/{Denominator}";

        public static Fraction operator +(Fraction frac) => frac;
        public static Fraction operator -(Fraction frac) => new Fraction(-frac.Numerator, (long)frac.Denominator);

        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        public static Fraction operator -(Fraction a, Fraction b) => a + -b;
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        public static Fraction operator /(Fraction a, Fraction b) => a * new Fraction(b.Denominator, b.Numerator);

        public static explicit operator double(Fraction frac) => (double)frac.Numerator / frac.Denominator;
    }
}