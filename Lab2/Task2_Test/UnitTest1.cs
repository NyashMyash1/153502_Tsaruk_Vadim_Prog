using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_2;

namespace Task2_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task2 method = new Task2();
            int test = method.Solution(4, 4);
            Assert.AreEqual(1, test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Task2 method = new Task2();
            int test = method.Solution(3, 4);
            Assert.AreEqual(2, test);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Task2 method = new Task2();
            int test = method.Solution(16, 16);
            Assert.AreEqual(0, test);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Task2 method = new Task2();
            int test = method.Solution(-3, 5);
            Assert.AreEqual(2, test);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Task2 method = new Task2();
            int test = method.Solution(15, 15);
            Assert.AreEqual(0, test);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Task2 method = new Task2();
            int test = method.Solution(-7, 7);
            Assert.AreEqual(1, test);
        }
    }
}
