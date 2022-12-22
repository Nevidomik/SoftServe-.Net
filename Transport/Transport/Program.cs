using System;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            Submarine U = new Submarine(1000, 15, true, 44, "Raich", "U-243", 1);
            Car Ziguli = new Car(1000, 100, true, "VAZ-2100");
            Fighter Su = new Fighter(1000, 750, true, "Su-25");
            Transp[] array = new Transp[3] { U, Ziguli, Su };
            
            Transp MaxSpeed()
            {
                Transp max = array[0];
                foreach (var obj in array)
                { 
                    if (obj.GetSpeed() > max.GetSpeed()) {
                        max = obj;
                    }
                }
                return max;
            }

            Console.WriteLine($"Fasted speed - {MaxSpeed().GetSpeed()}");
        }
    }
}
