using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ex obj = new ex();
            
        }
        class ex
        {
            public void Start_one()
            {
                char symbol;
                string line = "";
                int space = 0;
                do
                {
                    symbol = Console.ReadKey().KeyChar;
                    line += symbol;
                    if (symbol == ' ')
                        space++;
                } while (symbol != '.');
                Console.WriteLine($"Count space: {space}");
            }
            public void Start_two()
            {
                Console.WriteLine("Enter a number: ");
                string? ticket = Console.ReadLine();
                int one_half = Convert.ToInt32(ticket.Substring(0, 3));
                int two_half = Convert.ToInt32(ticket.Substring(3, 3));
                int s1 = 0, s2 = 0;
                while (one_half > 0 && two_half > 0)
                {
                    s1 = s1 + one_half % 10;
                    s2 = s2 + two_half % 10;

                    one_half = one_half / 10;
                    two_half = two_half / 10;

                }
                if (s1 == s2)
                {
                    Console.WriteLine("Luсky ticket!");
                }
                else
                {
                    Console.WriteLine("Just a ticket...");
                }
                //Console.WriteLine($"{one_half} \n {two_half} \n {ticket}");
            }
            public void Start_three()
            {
                Console.WriteLine("Enter A and B:");
                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());
                if (A < B)
                {
                    for (int i = 0; i <= (B - A); i++)
                    {
                        for (int j = 0; j < A + i; j++)
                        {
                            Console.Write($"{A + i} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            public void Start_four()
            {
                Console.WriteLine("Enter number: ");
                string? numb = Console.ReadLine();
                if (Convert.ToInt32(numb) > 0)
                {
                    char[] b = numb.ToCharArray();
                    Array.Reverse(b);
                    Console.WriteLine(b);
                }
            }
            public void Srart_five()
            {
                int month = 0;
                double deposit = 10000;
                Console.WriteLine("Enter P: ");
                double P = Convert.ToDouble(Console.ReadLine());
                if (P > 0 && P < 25)
                {
                    P = P / 100;
                    while (deposit < 11000)
                    {
                        deposit = deposit + deposit * P;
                        month++;
                    }
                    Console.WriteLine($"Final bank account {deposit} after {month} month");
                }
            }
        }
    }
}

