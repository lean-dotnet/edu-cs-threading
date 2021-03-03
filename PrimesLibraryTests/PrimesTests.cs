using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesLibrary;
using System;
using System.Collections.Generic;
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
            Assert.AreEqual(isOneAPrimeNumber, false);
        }

        [TestMethod()]
        public void IsTwoAPrimeNumberTest()
        {
            bool isTwoAPrimeNumber = Primes.IsPrimeNumber(2);
            Assert.AreEqual(isTwoAPrimeNumber, true);
        }
    }
}