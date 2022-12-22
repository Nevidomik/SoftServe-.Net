using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    abstract class Transp
    {
        public string? Brand { get; }
        public abstract int Price { get; }
        protected int Speed { get; set; }
        public bool Fuel { get; set; }
        public int Seats { get; }
        public void Move()
        {
            Console.WriteLine("Some move transport.");
        }
        public void Breakage()
        {
            Console.WriteLine("Some breakage transport.");
        }
        public void Refueling()
        {
            Console.WriteLine("Some refueling transport.");
        }

        public int GetSpeed()
        {
            return this.Speed;
        }
    }
}
