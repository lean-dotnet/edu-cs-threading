using System;

namespace PrimesLibrary
{
    public static class Primes
    {
        public static event Action<long> Progress;

        public static bool IsPrimeNumber(long number)
        {
            // Handling egde cases
            if (number < 2) return false;
            if (number == 2) return true;

            // Handling even numbers
            if (number % 2 == 0) return false;

            // And my sieve ...
            for (long divisor = 3; divisor <= (long)Math.Sqrt(number); divisor += 2)
            {
                if (number % divisor == 0) return false;
            }

            return true;
        }

        public static long CountPrimeNumbers(long fromInclusive, long toExclusive)
        {
            // Calculating 10% steps (bullshit if difference is below ten)
            long stepWidth = (toExclusive - fromInclusive) / 10 + 1;

            Console.WriteLine(stepWidth);

            long count = 0;
            long steps = 0;
            for (long z = fromInclusive; z < toExclusive; z++)
            {
                if (z % stepWidth == 0) Progress?.Invoke(++steps * 10);
                if (IsPrimeNumber(z)) ++count;
            }
            return count;
        }
    }
}
