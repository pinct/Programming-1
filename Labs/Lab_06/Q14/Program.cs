using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Pay Rate.");
            double pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours worked.");
            double hours = Convert.ToDouble(Console.ReadLine());
            double total = hours * pay;
            switch (total <= 300)
            {
                case true:
                    Console.WriteLine($"Gross Pay: {total}.");
                    Console.WriteLine($"Tax withholding: {total*.1}.");
                    Console.WriteLine($"Net Pay: {total*.9}.");
                    break;
                default:
                    Console.WriteLine($"Gross Pay: {total}.");
                    Console.WriteLine($"Tax withholding: {total * .12}.");
                    Console.WriteLine($"Net Pay: {total * .88}.");
                    break;
            }
        }
    }
}
