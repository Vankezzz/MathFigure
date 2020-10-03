using System;
using System.Collections.Generic;
using System.Text;

namespace MathFigure.Interfaces
{
    public interface IPolygon
    {
        public string Title { get; }
        public string Type { get; }

        public byte SidesCount { get; }
        public List<double> SidesLength { get; }

        public string CheckType();
        public double GetArea();
        public double GetPerimetr();
    }
}
