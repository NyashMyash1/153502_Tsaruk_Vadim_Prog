using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1;

namespace Task1_Test
{
    [TestClass]
    public class UnitTest1
    {
        ATS mts = ATS.GetInstanceATS();

        [TestMethod]
        public void TestMethod1()
        {
            mts.Clients = 1000;
            mts.ATSTariffOn();
            mts.TariffCostUp(1.5);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(45000, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            mts.Clients = 500;
            mts.TariffCostUp(1);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(37500, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            mts.Clients = 100;
            mts.TariffCostDown(2);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(1500, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            mts.Clients = 1;
            mts.TariffCostUp(0.5);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            mts.Clients = 10000;
            mts.TariffCostDown(0.5);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(150000, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            mts.Clients = 100;
            mts.TariffCostUp(0.4);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(2700, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            mts.Clients = 10;
            mts.TariffCostUp(1.1);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(600, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            mts.Clients = 1000;
            mts.TariffCostDown(2);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            mts.Clients = 100;
            mts.TariffCostUp(0.1);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(300, result);
        }

        [TestMethod]
        public void TestMethodSubsFee()
        {
            mts.Clients = 10000;
            mts.TariffCostUp(0.4);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Assert.AreEqual(150000, result);
        }
    }
}
