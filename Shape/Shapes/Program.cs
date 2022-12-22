using System;

namespace Shapes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Square square = new Square(5);
            CompiledShape shapes = new CompiledShape(square);
            Console.WriteLine(square.GetArea());
            Console.WriteLine(shapes.GetPerimeter()); 
        }
    }
}
