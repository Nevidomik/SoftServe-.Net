using System;

namespace Lab_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.AddEmployee();
            factory.AddProduct();
            Console.WriteLine(factory.ToString());
        }
    }
}
