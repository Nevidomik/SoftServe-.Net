using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Factory
{
    internal class Employee
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public string? Phone;

        public override string ToString()
        {
            string str = $"\nName employee: {Name}, surname: {Surname}, birth date: {BirthDate}, salary {Salary}, phone {Phone}";
            return str;
        }

        public Employee()
        { 
            Console.Write("Employee\n Name: "); 
            Name = Console.ReadLine();
            Console.Write("Surame: ");
            Surname = Console.ReadLine();
            Console.Write("Bith date: ");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Salary: ");
            Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Phone: ");
            Phone = Console.ReadLine();
        }
    }
}
