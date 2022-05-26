using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Task1;

namespace UnitTestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Shop ozon = new Shop();
            ozon.AddProduct("Jacket", 25);
            ozon.AddProduct("Cap", 10);
            ozon.AddProduct("Boots", 30);
            ozon.AddClient("Ivan", ClientCountry.Russia);
            ozon.StartCall("Ivan");
            ozon.BuyProduct("Jacket");
            ozon.BuyProduct("Cap");
            Assert.AreEqual(35, ozon.GetSumByNameTest("Ivan"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Shop ozon = new Shop();
            ozon.AddProduct("Jacket", 25);
            ozon.AddProduct("Cap", 10);
            ozon.AddProduct("Boots", 30);
            ozon.AddClient("Ivan", ClientCountry.Russia);
            ozon.StartCall("Ivan");
            ozon.BuyProduct("Boots");
            ozon.BuyProduct("Cap");
            Assert.AreEqual(40, ozon.GetSumByNameTest("Ivan"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Shop ozon = new Shop();
            ozon.AddProduct("Jacket", 25);
            ozon.AddProduct("Cap", 10);
            ozon.AddProduct("Boots", 30);
            ozon.AddClient("Ivan", ClientCountry.Russia);
            ozon.StartCall("Ivan");
            ozon.BuyProduct("Cap");
            Assert.AreEqual(10, ozon.GetSumByNameTest("Ivan"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Shop ozon = new Shop();
            ozon.AddProduct("Jacket", 25);
            ozon.AddProduct("Cap", 10);
            ozon.AddProduct("Boots", 30);
            ozon.AddClient("Ivan", ClientCountry.Russia);
            Assert.AreEqual(0, ozon.GetSumByNameTest("Ivan"));
        }

        
    }
}
