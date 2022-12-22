using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : GeometryShape
    {
        int sideA, sideB;
        public Rectangle(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public override int GetArea()
        {
            return sideA * sideB;
        }

        public override int GetPerimeter()
        {
            return sideA * 2 + sideB * 2;
        }
    }
}
