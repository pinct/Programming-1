using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 4;
            double tax = 0.1;
            Console.WriteLine($"{CalculateTax(cost)}");
            Console.WriteLine($"{CalculateTax(cost, tax)}");
        }
        static double CalculateTax(double cost, double tax = 0.14)
        {
            return cost * (1 + tax);
        }
    }
}
