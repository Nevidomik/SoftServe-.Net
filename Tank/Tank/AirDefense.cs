using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal class AirDefense : CombatVehicle
    {
        double range, fireRate, mobility;
        public AirDefense(string type, string model, double health, double range, double fireRate, double mobility)
        {
            this.type = type;
            this.model = model;
            this.health = health;
            this.range = range;
            this.fireRate = fireRate;
            this.mobility = mobility;
        }

        public override double Attack()
        {
            if (!IsDestroyed())
                return 150 + range * (fireRate / 10);
            return 0;
        }
        public override void Defense(double damage)
        {
            health -= damage / mobility;
        }
    }
}
