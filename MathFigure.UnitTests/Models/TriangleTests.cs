using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFigure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathFigure.Models.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TypeTest_3and4and5_RightTriangleReturned()
        {
            //arrange
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            string expected = "Right Triangle";

            //act
            Triangle triangle = new Triangle("Test1", firstSide,secondSide,thirdSide);
            string actual = triangle.Type;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TypeAreaTest_4and4and4_EquilateralTriangleReturned()
        {
            // arrange
            double firstSide = 4;
            double secondSide = 4;
            double thirdSide = 5;
            string expected = "Isosceles Triangle";

            //act
            Triangle triangle = new Triangle("Test2", firstSide, secondSide, thirdSide);
            string actual = triangle.Type;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TypeAreaTest_4and4and4_IsoscelesTriangleTriangleReturned()
        {
            // arrange
            double firstSide = 4;
            double secondSide = 4;
            double thirdSide = 4;
            string expected = "Equilateral Triangle";

            //act
            Triangle triangle = new Triangle("Test3", firstSide, secondSide, thirdSide);
            string actual = triangle.Type;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTest_4and4and4_6Returned()
        {
            // arrange
            double firstSide = 4;
            double secondSide = 4;
            double thirdSide = 4;
            double expected = 6.93;

            //act
            Triangle triangle = new Triangle("Test3", firstSide, secondSide, thirdSide);
            double actual = Math.Round(triangle.GetArea(),2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimetrTest_4and4and4_12Returned()
        {
            // arrange
            double firstSide = 4;
            double secondSide = 4;
            double thirdSide = 4;
            double expected = 12;

            //act
            Triangle triangle = new Triangle("Test3", firstSide, secondSide, thirdSide);
            double actual = triangle.GetPerimetr();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}