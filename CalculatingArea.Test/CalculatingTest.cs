using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace CalculatingTheArea.Test
{

    [TestFixture]
    public class CalculatingTest
    {
        [Test]
        public void Circle()
        {
            Assert.AreEqual(3.14, CalculatingArea.Squares.SquareCircle(1));
            Assert.AreEqual(12.57, CalculatingArea.Squares.SquareCircle(2));
            Assert.AreEqual(0, CalculatingArea.Squares.SquareCircle(0));
            Assert.Throws<ArgumentException>(() => CalculatingArea.Squares.SquareCircle(-1));
            Assert.Throws<ArgumentException>(() => CalculatingArea.Squares.SquareCircle(-2));
        }

        [Test]
        public void Triangle()
        {
            Assert.IsTrue(CalculatingArea.Squares.RightTriangle(3, 4, 5));
            Assert.IsTrue(CalculatingArea.Squares.RightTriangle(6, 8, 10));
            Assert.IsFalse(CalculatingArea.Squares.RightTriangle(2, 2, 3));

            Assert.Throws<ArgumentException>(() => CalculatingArea.Squares.RightTriangle(3, 4, -5));
            Assert.Throws<ArgumentException>(() => CalculatingArea.Squares.RightTriangle(-3, 4, 5));
            Assert.Throws<ArgumentException>(() => CalculatingArea.Squares.RightTriangle(3, -4, 5));


            Assert.AreEqual(1.98, CalculatingArea.Squares.SquareTriangle(2, 2, 3));
            Assert.AreEqual(6, CalculatingArea.Squares.SquareTriangle(3, 4, 5));

            Assert.Throws<ArgumentException>(() => CalculatingArea.Squares.SquareTriangle(1, 2, 3));
            Assert.Throws<ArgumentException>(() => CalculatingArea.Squares.SquareTriangle(2, -2, 3));
        }
    }
}