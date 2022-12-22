using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal class ArmoredCar : CombatVehicle
    {
        int countWeapon, speed;

        public ArmoredCar(string type, string model, double health, int countWeapon, int speed)
        {
            this.type = type;
            this.model = model;
            this.health = health;
            this.countWeapon = countWeapon;
            this.speed = speed;
        }
        public override double Attack()
        {
            if (!IsDestroyed())
                return 50 * countWeapon;
            return 0;
        }
        public override void Defense(double damage)
        {
            if (damage >= speed / 2)
                health -= (damage - speed / 2);
        }
    }
}
