using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : GeometryShape
    {
        int sideA, sideB, sideC;
        public Triangle (int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override int GetArea()
        {
            return (int)Math.Sqrt(Convert.ToDouble(GetPerimeter() * (GetPerimeter() - sideA) * (GetPerimeter() - sideB) * (GetPerimeter() - sideC)));
        }
        public override int GetPerimeter()
        {
            return sideA + sideB + sideB;
        }

    }
}
