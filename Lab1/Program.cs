using System;

namespace ConsoleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new { Name = "Tom", Age = 34 };
            Console.WriteLine(user);
        }

        class animal
        {
            public virtual void Move()
            {
                Console.WriteLine("Animal move");
            }
        }

        class cat : animal
        {
            public override void Move()
            {
                Console.WriteLine("Cat move");
            }
        }

    }
}
