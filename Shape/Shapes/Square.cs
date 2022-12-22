using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : GeometryShape
    {
        int side;

        public Square (int side)
        {
            this.side = side;
        }

        public override int GetArea()
        {
            return side * side;
        }

        public override int GetPerimeter()
        {
            return side * 4;
        }
    }
}
