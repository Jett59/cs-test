namespace app
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Random rand = new Random();
            Fraction frac1 = new Fraction(rand.NextInt64(100), rand.NextInt64(100));
            Fraction frac2 = new Fraction(rand.NextInt64(100), rand.NextInt64(100));
            Fraction frac3 = frac1 + frac2;
            Console.WriteLine($"{frac1.simplify()}+{frac2.simplify()} = {frac3.simplify()}");
        }
    }
}