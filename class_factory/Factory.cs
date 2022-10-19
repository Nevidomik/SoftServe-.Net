using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Factory
{
    internal class Factory
    {
        public string? Name { get; set; }
        public Employee[] array_employee;
        public Product[] array_product;

        decimal FTotalSalary()
        {
            decimal totalSalary = 0;
            foreach(var i in array_employee)
                totalSalary += i.Salary;
            return totalSalary;
        }
        decimal FAvgSalary()
        {
            decimal avg = FTotalSalary() / array_employee.Length;
            return avg;
        }
        decimal FGDP()
        {
            decimal totalprice = 0;
            foreach (var i in array_product)
                totalprice += i.Prise;
            decimal gdp = totalprice / array_employee.Length;
            return gdp;
        }
        
        public decimal GDP
        {
            get { return FGDP(); }
        }
        public decimal AvgSalary
        {
            get { return FAvgSalary(); }
        }
        public decimal TotalSalary
        {
            get { return FTotalSalary(); }
        }
        public int WorkersCount
        {
            get {return array_employee.Length;}
        }

        public override string ToString()
        {
            string str = $"Name Factory: {Name} Workers count: {WorkersCount}, total salary {TotalSalary}, avg salary: {AvgSalary}, GDP: {GDP}\n\n";
            for(int i = 0; i < array_employee.Length; i++)
                str += array_employee[i].ToString();
            for (int i = 0; i < array_product.Length; i++)
                str += array_product[i].ToString();
            return str;
        }

        public Factory()
        {
            Console.Write("Name factory: ");
            Name = Console.ReadLine();
        }
        public void AddEmployee()
        {
            Console.Write("Count employees: ");
            int emp_count = Convert.ToInt32(Console.ReadLine());
            array_employee = new Employee[emp_count];
            for(int i = 0; i < emp_count; i++)
                array_employee[i] = new Employee();
        }
        public void AddProduct()
        {
            Console.Write("Count product: ");
            int prod_count = Convert.ToInt32(Console.ReadLine());
            array_product = new Product[prod_count];
            for (int i = 0; i < prod_count; i++)
                array_product[i] = new Product();
        }
    }
}
