using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimesLibrary.Tests
{
    [TestClass()]
    public class PrimesTests
    {
        [TestMethod()]
        public void IsOneAPrimeNumberTest()
        {
            bool isOneAPrimeNumber = Primes.IsPrimeNumber(1);
            Assert.AreEqual(false, isOneAPrimeNumber);
        }

        [TestMethod()]
        public void IsTwoAPrimeNumberTest()
        {
            bool isTwoAPrimeNumber = Primes.IsPrimeNumber(2);
            Assert.AreEqual(true, isTwoAPrimeNumber);
        }

        [TestMethod()]
        public void IsThreeAPrimeNumberTest()
        {
            bool isThreePrimeNumber = Primes.IsPrimeNumber(3);
            Assert.AreEqual(true, isThreePrimeNumber);
        }

        [TestMethod()]
        public void IsEvenNumberAPrimeNumberTest()
        {
            Random rnd = new System.Random();
            ulong evenNumber = (ulong)(rnd.Next() + 1) * 2;

            bool isEvenNumberPrimeNumber = Primes.IsPrimeNumber(evenNumber);
            Assert.AreEqual(false, isEvenNumberPrimeNumber);
        }

        [TestMethod()]
        public void WellKnownPrimeNumbersTest()
        {
            // Three non-primes: 25, 39 and 77
            ulong[] numbers = new ulong[] { 5, 7, 11, 13, 19, 23, 25, 29, 39, 71, 77, 173 };

            int primesCount = numbers.Select(z => Primes.IsPrimeNumber(z)).Where(isPrime => isPrime).Count();
            Assert.AreEqual(numbers.Length - 3, primesCount);
        }
    }
}