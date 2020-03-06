using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelC_301106259_FinalQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{CalculateCommision(900)}");
            Console.WriteLine($"{CalculateCommision(1000)}");
            Console.WriteLine($"{CalculateCommision(2000)}");
        }
        static double CalculateCommision(double saleAmount)
        {
            double commision = 0;
            double percent = 0.01;
            if (saleAmount > 1000)
            {
                commision = percent * saleAmount;
            }
            return commision;
        }
    }
}
