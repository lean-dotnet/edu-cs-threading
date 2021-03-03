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
            long evenNumber = (long)(rnd.Next() + 1) * 2;

            bool isEvenNumberPrimeNumber = Primes.IsPrimeNumber(evenNumber);
            Assert.AreEqual(false, isEvenNumberPrimeNumber);
        }

        [TestMethod()]
        public void WellKnownPrimeNumbersTest()
        {
            // Three non-primes: 25, 39 and 77
            long[] numbers = new long[] { 5, 7, 11, 13, 19, 23, 25, 29, 39, 71, 77, 173 };

            int primesCount = numbers.Select(z => Primes.IsPrimeNumber(z)).Where(isPrime => isPrime).Count();
            Assert.AreEqual(numbers.Length - 3, primesCount);
        }

        [TestMethod()]
        public void CountPrimeNumbersTest()
        {
            // See https://en.wikipedia.org/wiki/Prime_number_theorem
            // or https://www.michael-holzapfel.de/themen/primzahlen/pz-anzahl.htm

            Assert.AreEqual(4, Primes.CountPrimeNumbers(1, 10));
            Assert.AreEqual(25, Primes.CountPrimeNumbers(1, 100));
            Assert.AreEqual(168, Primes.CountPrimeNumbers(1, 1000));
            Assert.AreEqual(1229, Primes.CountPrimeNumbers(1, 10000));
            Assert.AreEqual(9592, Primes.CountPrimeNumbers(1, 100000));
        }

        [TestMethod()]
        public void ProgressReportingTest()
        {
            int callCount = 0;
            Primes.Progress += (percent) => ++callCount;

            Primes.CountPrimeNumbers(1, 27389);

            // Calls for percent 10%, 20%, ... 100%
            Assert.AreEqual(9, callCount);
        }
    }
}