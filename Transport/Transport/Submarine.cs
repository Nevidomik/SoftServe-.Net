using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Submarine : WaterTransp
    {
        public string? Brand { get; }
        public override int Price { get; }
        public int Seats { get; }
        public override string? Type { get; }
        public override int CountCrew { get; }
        public Submarine(int price, int speed, bool fuel, int seats, string brand, string type, int count)
        {
            Price = price; Speed = speed; Fuel = fuel; Seats = seats; Brand = brand; Type = type; CountCrew = count;
        }
        public override void Dock()
        {
            Console.WriteLine("Submarin in dock.");
        }
        public override void SetSail()
        {
            Console.WriteLine("Set sail submarine");
        }
        public void Move()
        {
            Console.WriteLine("Move submarine");
        }
        public void Breakage() { Console.WriteLine("Breakage Submarine"); }
        public void Refueling()
        {
            Fuel = true;
        }
    }
}
