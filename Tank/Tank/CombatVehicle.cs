using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal abstract class CombatVehicle
    {
        protected double health;
        protected string type, model;

        public bool IsDestroyed()
        {
            if (health <= 0)
                return true;
            return false;
        }
        public void ShofInfo()
        {
            Console.WriteLine($"Type: {type} \n Model: {model}\n Health: {health} \n Destroyed: {IsDestroyed()}");
        }
        public abstract double Attack();
        public abstract void Defense(double damage);

    }
}
