using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// Fibonacci sequence test,
    /// F0 = 0, F1 = 1,
    /// Fn = F{n-1} + F{n-2}
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodCS()
        {
            //Arrange
            var expected = new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            var actual = new long[expected.Length];

            //Act
            for (long i = 0; i < expected.Length; i++)
            {
                actual[i] = CSFibonacci.Program.Fibonacci(i);
            }

            //Asset
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodFS()
        {
            //Arrange
            var expected = new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            var actual = new BigInteger[expected.Length];

            //Act
            for (long i = 0; i < expected.Length; i++)
            {
                actual[i] = FSFibonacci.Program.Fibonacci(i);
            }

            //Asset
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}