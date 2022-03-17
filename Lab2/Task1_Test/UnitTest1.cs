using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1;

namespace Task1_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task1 method = new Task1();
            bool test = method.divide(4, 2);
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Task1 method = new Task1();
            bool test = method.divide(3, 2);
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Task1 method = new Task1();
            bool test = method.divide(5, 5);
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Task1 method = new Task1();
            bool test = method.divide(0, 1);
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Task1 method = new Task1();
            bool test = method.divide(1, 2);
            Assert.IsFalse(test);
        }
    }
}
