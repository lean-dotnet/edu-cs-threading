using System;

namespace PrimesLibrary
{
    public static class Primes
    {
        public static bool IsPrimeNumber(ulong z)
        {
            // Handling egde cases
            if (z < 2) return false;
            if (z == 2) return true;

            // Handling even numbers
            if (z % 2 == 0) return false;

            return true;
        }
    }
}
