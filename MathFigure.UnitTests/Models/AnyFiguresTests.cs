using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFigure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathFigure.Models.Tests
{
    [TestClass()]
    public class AnyFiguresTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            //arrange
            List<Dots> dots = new List<Dots>() { new Dots(20, 40), new Dots(38, 20), new Dots(10, 10), new Dots(5, 15) };
            double expected = 470;

            //act
            AnyFigures anyFigures = new AnyFigures("Test1", dots);
            double actual = Math.Round(anyFigures.GetArea(), 3);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimetrTest()
        {
            //arrange
            List<Dots> dots = new List<Dots>() { new Dots(20, 40), new Dots(38, 20), new Dots(10, 10), new Dots(5, 15) };
            double expected = 56.639;

            //act
            AnyFigures anyFigures = new AnyFigures("Test2", dots);
            double actual = Math.Round(anyFigures.GetPerimetr(), 3);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}