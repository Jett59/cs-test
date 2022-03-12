namespace app
{
    class MathHelper
    {
        // Euclidean algorithm for the greatest common divisor of a and b
        public static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a | b;
        }
    }
}