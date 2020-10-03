using MathFigure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathFigure.Models
{
    public class Triangle : IPolygon
    {
        public string Title { get; private set; }
        public byte SidesCount { get; private set; }
        public string Type { get; private set; }
        public List<double> SidesLength { get; private set; }

        public Triangle(string title, double firstSide,double secondSide,double thirdSide)
        {
            Title = title;
            SidesCount = 3;
            SidesLength = new List<double>() { firstSide, secondSide, thirdSide};
            Type = CheckType();
        }
        public string CheckType()
        {
            if (CheckRightTriangle()) return "Right Triangle";
            if (CheckEquilateralTriangle()) return "Equilateral Triangle";
            if (CheckIsoscelesTriangle()) return "Isosceles Triangle";
            return "Universal";
        }
        private bool CheckRightTriangle()
        {
            double MaxItem = SidesLength.Max();
            List<double> Sides = SidesLength.GetRange(0,SidesLength.Count());
            Sides.Remove(MaxItem);
            if (MaxItem == Math.Sqrt(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2)))
            {
                return true;
            }
            else return false;
        }
        private bool CheckEquilateralTriangle()
        {
            if (SidesLength[0]==SidesLength[1] && SidesLength[0] == SidesLength[2])
            {
                return true;
            }
            else return false;
        }
        private bool CheckIsoscelesTriangle()
        {
            if (SidesLength[0] == SidesLength[1] || SidesLength[0] == SidesLength[2] || SidesLength[1] == SidesLength[2])
            {
                return true;
            }
            else return false;
        }
        public double GetArea()
        {
            double p = GetSemiPerimetr();
            return Math.Sqrt(p * (p - SidesLength[0]) * (p - SidesLength[1]) * (p - SidesLength[2]));
        }
        public double GetPerimetr()
        {
            return SidesLength.Sum();
        }

        private double GetSemiPerimetr()
        {
            return SidesLength.Sum() / 2;
        }
    }
}
