using System;
using System.Collections.Generic;
using System.Text;

namespace MathFigure.Interfaces
{
    interface ICircle
    {
        public string Title { get; }
        public double Radius { get; }

        public double GetArea();
        public double GetPerimetr();
    }
}
