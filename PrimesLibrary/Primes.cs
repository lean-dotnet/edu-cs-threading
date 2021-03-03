using System;

namespace PrimesLibrary
{
    public static class Primes
    {
        public static bool IsPrimeNumber(ulong number)
        {
            // Handling egde cases
            if (number < 2) return false;
            if (number == 2) return true;

            // Handling even numbers
            if (number % 2 == 0) return false;

            // And my sieve ...
            for (ulong divisor = 3; divisor <= (ulong) Math.Sqrt(number); divisor += 2)
            {
                if (number % divisor == 0) return false;
            }

            return true;
        }
    }
}
