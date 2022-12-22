using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : GeometryShape
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int GetArea()
        {
            return Convert.ToInt32(Math.PI * Math.Pow(radius, 2));
        }

        public override int GetPerimeter()
        {
            return Convert.ToInt32(2 * Math.PI * radius);
        }
    }
}
