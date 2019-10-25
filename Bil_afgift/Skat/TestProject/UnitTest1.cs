using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Check a low priced car. Positive if actual and expected are equal
        /// </summary>
        [TestMethod]
        public void BilAfgift_LowPrice()
        {
            int actual = Skat.Afgift.BilAfgift(100000);
            int expected = 85000;

            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Check a high priced car. Positive if actual and expected are equal
        /// </summary>
        [TestMethod]
        public void BilAfgift_HighPrice()
        {
            int actual = Skat.Afgift.BilAfgift(210000);
            int expected = 185000;

            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// positive if it receive an OutOfRangeException
        /// </summary>
        [TestMethod]
        public void BilAfgift_NegativePrice()
        {
            // this method should always throw an exception, as long as the parameter is 0 or negative
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Skat.Afgift.BilAfgift(-20));
        }

        /// <summary>
        /// Check a low priced electric cars. Positive if actual and expected are equal
        /// </summary>
        [TestMethod]
        public void ElbilAfgift_LowPrice()
        {
            int actual = Skat.Afgift.ElBilAfgift(100000);
            int expected = 17000;

            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Check a high priced electric car. Positive if actual and expected are equal
        /// </summary>
        [TestMethod]
        public void ElbilAfgift_HighPrice()
        {
            int actual = Skat.Afgift.ElBilAfgift(210000);
            int expected = 37000;

            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// positive if it receive an OutOfRangeException
        /// </summary>
        [TestMethod]
        public void ElbilAfgift_NegativePrice()
        {
            // this method should always throw an exception, as long as the parameter is 0 or negative
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Skat.Afgift.ElBilAfgift(-20));
        }
    }
}
