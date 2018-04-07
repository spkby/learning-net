using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// проверка правильности скидки
        /// </summary>

        [TestMethod]
        public void TestMethodDiscount1()
        {
            Goods good = new Goods("good",100);

            double res = Goods.getDiscount(good);

            Assert.AreEqual(3, res);

        }
        /// <summary>
        /// проверка правильности сложения
        /// </summary>

        [TestMethod]
        public void TestMethodSum1()
        {
            Goods good1 = new Goods("good1", 100);
            Goods good2 = new Goods("good2", 100);

            Goods res = good1 + good2;

            Assert.AreEqual(200, res.price);

        }
    }
}
