using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassNOD;

namespace UnitTestProject1
{
    [TestClass]
    public class UTNOD
    {
        [TestMethod]
        public void TestNODEv4_1()
        {
            int a = 33, b = 6, c = 9, d = 12, actual, expected = 3;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a,b,c,d);
            Assert.AreEqual(expected,actual, "not corretly");
        }
        [TestMethod]
        public void TestNODEv4_2()
        {
            int a = 12, b = 4, c = 6, d = 8, actual, expected = 2;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b, c, d);
            Assert.AreEqual(expected, actual, "not corretly");
        }
        [TestMethod]
        public void TestNODEv4_3()
        {
            int a = 15, b = 10, c = 45, d = 105, actual, expected = 5;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b, c, d);
            Assert.AreEqual(expected, actual, "not corretly");
        }

        [TestMethod]
        public void TestNODEv3_1()
        {
            int a = 33, b = 6, c = 9, actual, expected = 3;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b, c);
            Assert.AreEqual(expected, actual, "not corretly");
        }
        [TestMethod]
        public void TestNODEv3_2()
        {
            int a = 12, b = 4, c = 6, actual, expected = 2;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b, c);
            Assert.AreEqual(expected, actual, "not corretly");
        }
        [TestMethod]
        public void TestNODEv3_3()
        {
            int a = 15, b = 10, c = 45, actual, expected = 5;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b, c);
            Assert.AreEqual(expected, actual, "not corretly");
        }

        [TestMethod]
        public void TestNODEv2_1()
        {
            int a = 33, b = 6, actual, expected = 3;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b);
            Assert.AreEqual(expected, actual, "not corretly");
        }
        [TestMethod]
        public void TestNODEv2_2()
        {
            int a = 12, b = 4, actual, expected = 4;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b);
            Assert.AreEqual(expected, actual, "not corretly");
        }
        [TestMethod]
        public void TestNODEv2_3()
        {
            int a = 15, b = 10, actual, expected = 5;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b);
            Assert.AreEqual(expected, actual, "not corretly");
        }

        [TestMethod]
        public void TestNODSt2_1()
        {
            int a = 33, b = 6, actual, expected = 3;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b);
            Assert.AreEqual(expected, actual, "not corretly");
        }
        [TestMethod]
        public void TestNODSt2_2()
        {
            int a = 12, b = 4, actual, expected = 4;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b);
            Assert.AreEqual(expected, actual, "not corretly");
        }
        [TestMethod]
        public void TestNODSt2_3()
        {
            int a = 15, b = 10, actual, expected = 5;
            ClassNODEv nod = new ClassNODEv();
            actual = nod.NOD(a, b);
            Assert.AreEqual(expected, actual, "not corretly");
        }

    }
}
