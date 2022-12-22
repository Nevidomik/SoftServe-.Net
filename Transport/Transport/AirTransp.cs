using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    abstract class AirTransp : Transp
    {
        public abstract string? Type { get; }
        public int CountPilot { get; }
        public abstract void Rise();
        public abstract void Landing();
    }
}
