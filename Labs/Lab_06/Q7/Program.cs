using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double p;
            double d;
            Console.WriteLine("Enter A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter C");
            c = Convert.ToDouble(Console.ReadLine());
            switch (a == 0)
            {
                case true:
                    Console.WriteLine("Invalid input for A");
                    break;
                case false:
                    p = (-b)/(2*a);
                    d = b * b - (4 * a * c);
                    switch (d >= 0)
                    {
                        case true:
                            double q = Math.Sqrt(d) / (2 * a);
                            Console.WriteLine($"{p + q} and {p - q}");
                            break;
                        case false:
                            double q = Math.Sqrt(-d) / (2 * a);
                            Console.WriteLine($"{p} + {q}i and {p} - {q}i");
                            break;
                    }
                    break;
            }
        }
    }
}
