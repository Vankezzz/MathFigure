using MathFigure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathFigure.Models
{
    public class Circle:ICircle
    {
        public double Radius { get; private set; }

        public string Title { get; private set; }

        public Circle(string title,double radius)
        {
            Radius = radius;
            Title = title;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
