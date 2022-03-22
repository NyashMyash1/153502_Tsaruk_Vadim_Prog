using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task3;

namespace Task3_Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethodGetDay1()
        {
            DateService method = new DateService();
            string test = method.GetDay("22 марта 2022");
            Assert.AreEqual(test, "Вторник");
        }

        [TestMethod]
        public void TestMethodGetDay2()
        {
            DateService method = new DateService();
            string test = method.GetDay("21 марта 2022");
            Assert.AreEqual(test, "Понедельник");
        }

        [TestMethod]
        public void TestMethodGetDay3()
        {
            DateService method = new DateService();
            string test = method.GetDay("1 апреля 2022");
            Assert.AreEqual(test, "Пятница");
        }

        [TestMethod]
        public void TestMethodGetDay4()
        {
            DateService method = new DateService();
            string test = method.GetDay("7 мая 2022");
            Assert.AreEqual(test, "Суббота");
        }

        [TestMethod]
        public void TestMethodGetDay5()
        {
            DateService method = new DateService();
            string test = method.GetDay("13 июля 2020");
            Assert.AreEqual(test, "Понедельник");
        }

        [TestMethod]
        public void TestMethodGetDaysSpan1()
        {
            DateService method = new DateService();
            string test = method.GetDaysSpan(20, 03, 2022);
            Assert.AreEqual(test,"02");
        }

        [TestMethod]
        public void TestMethodGetDaysSpan2()
        {
            DateService method = new DateService();
            string test = method.GetDaysSpan(1, 03, 2022);
            Assert.AreEqual(test, "21");
        }

        [TestMethod]
        public void TestMethodGetDaysSpan3()
        {
            DateService method = new DateService();
            string test = method.GetDaysSpan(22, 03, 2021);
            Assert.AreEqual(test, "365");
        }
    }
}
