using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class CompiledShape : GeometryShape
    {
        GeometryShape [] obj;
        public CompiledShape (params GeometryShape[] obj)
        {
            this.obj = obj;
        }
        public override int GetPerimeter()
        {
            int sum = 0;
            foreach (var i in obj)
                sum += i.GetPerimeter();
            return sum;
        }
        public override int GetArea()
        {
            int sum = 0;
            foreach (var i in obj)
                sum += i.GetArea();
            return sum;
        }
    }
}
