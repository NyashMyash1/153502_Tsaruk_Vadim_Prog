using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1;

namespace Task1_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Minimum method = new Minimum();
            double actual = method.Min(5, 2);
            Assert.AreEqual(2 , actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Minimum method = new Minimum();
            double actual = method.Min(0, 0);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Minimum method = new Minimum();
            double actual = method.Min(2.9, 2.98);
            Assert.AreEqual(2.9, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Minimum method = new Minimum();
            double actual = method.Min(2.712, 2.71);
            Assert.AreEqual(2.71, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Minimum method = new Minimum();
            double actual = method.Min(-1, -0.99);
            Assert.AreEqual(-1, actual);
        }
    }
}
