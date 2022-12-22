using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Trapezoid: GeometryShape
    {
        int sideA, sideB, sideC, sideD;

        public Trapezoid (int sideA, int sideB, int sideC, int sideD)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }
        public override int GetArea()
        {
            return Convert.ToInt32(((sideA+sideB)/Math.Abs(sideA-sideB)) * Math.Sqrt((GetPerimeter() - sideA) * (GetPerimeter() - sideB) * (GetPerimeter() - sideA - sideC) * (GetPerimeter() - sideA - sideD)));
        }

        public override int GetPerimeter()
        {
            return sideA + sideB + sideC + sideD;
        }
    }
}
