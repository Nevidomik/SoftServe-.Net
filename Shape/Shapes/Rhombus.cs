using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rhombus : GeometryShape
    {
        int side, height;
        public Rhombus (int side, int height)
        {
            this.side = side;
            this.height = height;
        }
        public override int GetArea()
        {
            return side * height;
        }

        public override int GetPerimeter()
        {
            return side * 4;
        }
    }
}
