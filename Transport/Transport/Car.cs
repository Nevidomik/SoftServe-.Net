using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Car : LandTransp
    {
        public override int Price { get;  }
        public override string? Type { get; }
        public Car (int price, int speed, bool fuel,string type)
        {
            Price = price; Speed = speed; Fuel = fuel; Type = type;
        }

        public override void MoveByLand()
        {
            Console.WriteLine("Move car by land.");
        }

        public new void Move()
        {
            MoveByLand();
        }
        
    }
}
