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
            double pay;
            double hours;
            Console.WriteLine("Enter the pay rate.");
            pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the hours worked.");
            hours = Convert.ToDouble(Console.ReadLine());
            if (pay * hours > 300)
            {
                Console.WriteLine($"Gross pay: ${hours*pay}");
                Console.WriteLine($"Withholding Tax: ${hours * pay * .12}");
                Console.WriteLine($"Net pay: ${hours * pay * .88}");
            }
            else
            {
                Console.WriteLine($"Gross pay: ${hours * pay}");
                Console.WriteLine($"Withholding Tax: ${hours * pay * .10}");
                Console.WriteLine($"Net pay: ${hours * pay * .90}");
            }
        }
    }
}
