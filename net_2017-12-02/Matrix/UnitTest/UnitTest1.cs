using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matrixs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCostructor()
        {
            Matrix matrix = new Matrix(3,4);


            Assert.AreEqual(3,matrix.rows);

            Assert.AreEqual(4, matrix.columns);

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.columns; col++)
                {
                    matrix.fill(row,col,1);
                }
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.columns; col++)
                {
                    Assert.AreEqual(1,matrix.matrix[row, col]);
                }
            }           
        }

        [TestMethod]
        public void TestAdd()
        {
            Matrix m1 = new Matrix(3, 4);
            Matrix m2 = new Matrix(3, 4);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.columns; col++)
                {
                    m1.fill(row, col, 1);
                }
            }
            for (int row = 0; row < m2.rows; row++)
            {
                for (int col = 0; col < m2.columns; col++)
                {
                    m2.fill(row, col, 1);
                }
            }

            Matrix m = m1 + m2;

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.columns; col++)
                {
                    Assert.AreEqual(2, m.matrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestMult()
        {
            Matrix matrix = new Matrix(3, 4);
            
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.columns; col++)
                {
                    matrix.fill(row, col, 1);
                }
            }

            matrix = matrix * 2;

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.columns; col++)
                {
                    Assert.AreEqual(2, matrix.matrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestSub()
        {
            Matrix m1 = new Matrix(3, 4);
            Matrix m2 = new Matrix(3, 4);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.columns; col++)
                {
                    m1.fill(row, col, 1);
                }
            }
            for (int row = 0; row < m2.rows; row++)
            {
                for (int col = 0; col < m2.columns; col++)
                {
                    m2.fill(row, col, 1);
                }
            }

            Matrix m = m1 - m2;

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.columns; col++)
                {
                    Assert.AreEqual(0, m.matrix[row, col]);
                }
            }

        }

        [TestMethod]
        public void TestMult1()
        {
            Matrix m1 = new Matrix(3, 2);
            Matrix m2 = new Matrix(2, 3);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.columns; col++)
                {
                    m1.fill(row, col, 2);
                }
            }
            for (int row = 0; row < m2.rows; row++)
            {
                for (int col = 0; col < m2.columns; col++)
                {
                    m2.fill(row, col, 3);
                }
            }

            Matrix m = m1 * m2;

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.columns; col++)
                {
                    Assert.AreEqual(12, m.matrix[row, col]);
                }
            }
        }
        [TestMethod]
        public void TestMult2()
        {
            Matrix m1 = new Matrix(9, 3);
            Matrix m2 = new Matrix(3, 5);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.columns; col++)
                {
                    m1.fill(row, col, 2);
                }
            }
            for (int row = 0; row < m2.rows; row++)
            {
                for (int col = 0; col < m2.columns; col++)
                {
                    m2.fill(row, col, 3);
                }
            }

            Matrix m = m1 * m2;

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.columns; col++)
                {
                    Assert.AreEqual(18, m.matrix[row, col]);
                }
            }
        }
        [TestMethod]
        public void TestMult3()
        {
            Matrix m1 = new Matrix(9, 5);
            Matrix m2 = new Matrix(5, 6);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.columns; col++)
                {
                    m1.fill(row, col, 2);
                }
            }
            for (int row = 0; row < m2.rows; row++)
            {
                for (int col = 0; col < m2.columns; col++)
                {
                    m2.fill(row, col, 3);
                }
            }

            Matrix m = m1 * m2;

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.columns; col++)
                {
                    Assert.AreEqual(30, m.matrix[row, col]);
                }
            }
        }
    }
}
