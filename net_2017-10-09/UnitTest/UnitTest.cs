using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// треугольник существует
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Triangle triangle = new Triangle(0,0,0,1,1,0);

            bool res = triangle.CheckExist();

            Assert.AreEqual(true, res);
        }
        /// <summary>
        /// треугольник не существует
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            Triangle triangle = new Triangle(0, 0, 0, 0, 1, 1);
            bool res = triangle.CheckExist();
            Assert.AreEqual(false, res);
        }

        /// <summary>
        /// периметр треугольник 12
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            Triangle triangle = new Triangle(0, 0, 0, 3, 4, 0);

            double res = triangle.GetP();

            Assert.AreEqual(12, res, 0.000001);
        }

        /// <summary>
        /// площадь треугольник 6
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            Triangle triangle = new Triangle(0, 0, 0, 3, 4, 0);

            double res = triangle.GetS();

            Assert.AreEqual(6, res, 0.000001);
        }

        /// <summary>
        /// площадь треугольник 6
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            Point a, b, c;
            a.x = 0;
            a.y = 0;
            b.x = 0;
            b.y = 1;
            c.x = 1;
            c.y = 0;

            Triangle triangle = new Triangle(a,b,c);

            double res = triangle.GetS();

            Assert.AreEqual(0.5, res, 0.000001);
        }
    }
}
