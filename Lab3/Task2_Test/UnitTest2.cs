using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task2.Services;

namespace Task2_Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution method = new Solution();
            string test = String.Format("{0:f5}", method.Sol_Test(1));
            Assert.AreEqual("2.75587", test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution method = new Solution();
            string test = String.Format("{0:f5}", method.Sol_Test(-9));
            Assert.AreEqual("21.28851", test);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Solution method = new Solution();
            string test = String.Format("{0:f5}", method.Sol_Test(-15));
            Assert.AreEqual("150.11117", test);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Solution method = new Solution();
            string test = String.Format("{0:f5}", method.Sol_Test(10));
            Assert.AreEqual("22028.81712", test);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Solution method = new Solution();
            string test = String.Format("{0:f5}", method.Sol_Test(7));
            Assert.AreEqual("1098.64715", test);
        }
    }
}
