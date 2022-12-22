using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Parallelogram : GeometryShape
    {
        int sideA, sideB, height;
        public Parallelogram (int sideA, int sideB, int height)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.height = height;
        }
        public override int GetArea()
        {
            return sideA * height;
        }

        public override int GetPerimeter()
        {
            return sideA * 2 + sideB * 2;
        }
    }
}
