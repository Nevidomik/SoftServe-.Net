using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal class Tank : CombatVehicle
    {
        double reload, accuracy, thickness;
        public Tank(string type, string model, double health, double reload, double accuracy, double thickness)
        {
            this.type = type;
            this.model = model;
            this.health = health;
            this.reload = reload;
            this.accuracy = accuracy;
            this.thickness = thickness;
        }
        public override double Attack()
        {
            if(!IsDestroyed())
                return 100 * accuracy / reload;
            return 0;
        }
        public override void Defense(double damage)
        {
            if(damage >= thickness)
                health -= (damage - thickness);
        }
    }
}
