using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    abstract class WaterTransp : Transp
    {
        public abstract string? Type { get; }
        public abstract int CountCrew { get; }
        public abstract void SetSail();
        public abstract void Dock();

    }
}
