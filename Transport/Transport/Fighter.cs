using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Fighter : AirTransp
    {
        string? Weapon;
        public override int Price { get; }
        public override string? Type { get; }

        public Fighter(int price, int speed, bool fuel, string type)
        {
            Price = price; Speed = speed; Fuel = fuel; Type = type;
        }
        public override void Landing()
        {
            Console.WriteLine($"Landing {Type}");
        }

        public override void Rise()
        {
            Console.WriteLine($"Rise {Type}");
        }
    }
}
