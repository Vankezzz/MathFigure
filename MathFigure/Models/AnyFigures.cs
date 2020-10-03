using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathFigure.Models
{
    public class AnyFigures
    {
        public string Title { get; private set; }
        public List<Dots> Dots { get; private set; }
        /// <summary>
        /// Create any figure what has coordinates (dots) of vertices
        /// </summary>
        /// <param name="title"></param>
        /// <param name="dots"></param>
        public AnyFigures(string title, List<Dots> dots)
        {
            Title = title;
            Dots = dots;
        }

        public double GetArea()
        {
            double area=0;

            for (int i = 0; i < Dots.Count() - 1; i++)
            {
                area += Dots[i].X * Dots[i + 1].Y - Dots[i].Y * Dots[i + 1].X;
            }
            area += Dots.Last().X * Dots[0].Y - Dots.Last().Y * Dots[0].X;

            return Math.Abs(area) / 2;
        }
        public double GetPerimetr()
        {
            double perimetr = 0;

            for (int i = 1; i < Dots.Count() - 1; i++)
            {
                perimetr += Math.Sqrt(Math.Pow((Dots[i].X - Dots[i-1].X),2)+ Math.Pow((Dots[i].Y - Dots[i - 1].Y), 2));
            }

            return perimetr;
        }
    }
}
