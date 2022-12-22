using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Ellipse : GeometryShape
    {
        int arcA, arcB;
        public Ellipse(int arcA, int arcB)
        {
            this.arcA = arcA;
            this.arcB = arcB;
        }
        public override int GetArea()
        {
            return Convert.ToInt32(Math.PI * arcA * arcB);
        }

        public override int GetPerimeter()
        {
            return Convert.ToInt32(4 * ((Math.PI * arcA * arcB) + Math.Pow(arcA - arcB, 2)) / (arcA + arcB));
        }
    }
}
