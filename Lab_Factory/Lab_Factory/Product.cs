using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Factory
{
    internal class Product
    {
        public string? Name { get; set; }
        readonly DateTime ManufactureDate;
        public string? Category { get; set; }
        public decimal Prise { get; set; }

        public override string ToString()
        {
            string str = $"\nName product: {Name}, category: {Category}, manufacture date: {ManufactureDate}, prise: {Prise}";
            return str;
        }

        public Product()
        {
            Console.Write("***Product\n Name: ");
            Name = Console.ReadLine();
            ManufactureDate = DateTime.Now;
            Console.Write("Category: ");
            Category = Console.ReadLine();
            Console.Write("Prise: ");
            Prise = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
