using System;

namespace Tank
{
    class Program
    {
        static public void Main(string[] args)
        {
            CombatVehicle[] army1 = new CombatVehicle[10];
            for (int i = 0; i < 10; i++)
            {
                if (i < 4)
                    army1[i] = new Tank("heavy tank", "H-1", 100, 30, 20, 20);
                else if (i >= 4 && i < 7)
                    army1[i] = new ArmoredCar("armored horse", "BAH-30", 50, 1, 80);
                else
                    army1[i] = new AirDefense("heavy gun", "GG-1488", 20, 30, 20, 8);
            }
            CombatVehicle[] army2 = new CombatVehicle[10];
            for (int i = 0; i < 10; i++)
            {
                if (i < 4)
                    army2[i] = new Tank("ok heavy tank", "H-3", 100, 10, 15, 20);
                else if (i >= 4 && i < 7)
                    army2[i] = new ArmoredCar("armored horse", "BAH-30", 50, 2, 60);
                else
                    army2[i] = new AirDefense("heavy gun", "GG-1488", 20, 30, 40, 6);
            }

            while (Battle())
            {

            }

            bool Battle()
            {
                bool a1 = false, a2 = false;
                foreach (var i in army1)
                {
                    if (!i.IsDestroyed())
                        a1 = true;
                    else
                    {
                        i.ShofInfo();
                        army1 = army1.Where(val => val != i).ToArray();
                    }
                }
                foreach (var i in army2)
                {
                    if (!i.IsDestroyed())
                        a2 = true;
                    else
                    {
                        i.ShofInfo();
                        army2 = army2.Where(val => val != i).ToArray();
                    }

                }
                if (a1 && a2)
                {
                    Rand();
                }
                else if (!a1)
                {
                    Console.WriteLine("Army - 1 is destroyed! Army 2 vicrory!");
                    return false;
                }
                else if (!a2)
                {
                    Console.WriteLine("Army - 2 is destroyed! Army 1 vicrory!");
                    return false;
                }
                return true;
            }
            void Rand()
            {
                Random rd = new Random();
                int r1, r2;

                r1 = rd.Next(0, army1.Count());
                r2 = rd.Next(0, army2.Count());

                while (!army1[r1].IsDestroyed() && !army2[r2].IsDestroyed())
                    Round(army1[r1], army2[r2]);
            }

            void Round(CombatVehicle bm1, CombatVehicle bm2)
            {
                Random rd = new Random();
                int r;
                while (!bm1.IsDestroyed() && !bm2.IsDestroyed())
                {
                    r = rd.Next(1, 2);
                    switch (r)
                    {
                        case 1:
                            bm2.Defense(bm1.Attack());
                            break;
                        case 2:
                            bm1.Defense(bm2.Attack());
                            break;
                    }
                }
            }
        }
    }
}