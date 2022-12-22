using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    abstract class LandTransp : Transp
    {
        public abstract string? Type { get; }

        public abstract void MoveByLand();

    }
}
