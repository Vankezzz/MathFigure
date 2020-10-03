using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFigure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathFigure.Models.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTest_5_79returned()
        {
            //arrange
            double radius = 5;
            double expected = 78.540;

            //act
            Circle circle = new Circle("Test1",radius);
            double actual = Math.Round(circle.GetArea(),3);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimetrTest_5_31returned()
        {
           //arrange
            double radius = 5;
            double expected = 31.416;

            //act
            Circle circle = new Circle("Test2", radius);
            double actual = Math.Round(circle.GetPerimetr(), 3);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}