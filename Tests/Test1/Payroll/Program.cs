using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        //Michael Courneya - 301106259 - 004
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Social Security number.");
            string social = Console.ReadLine();
            Console.WriteLine("Enter your hourly pay.");
            double hourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number of hours worked.");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Payroll Summary for: {name}");
            Console.WriteLine($"SSN: {social}");
            if (hourly == (int)hourly)
            {
                Console.WriteLine($"You worked {hours} hours at ${hourly}.00 per hour.");
            }
            else if (hourly * 10 == (int)(hourly * 10))
            {
                Console.WriteLine($"You worked {hours} hours at ${hourly}0 per hour.");
            }
            else
            {
                Console.WriteLine($"You worked {hours} hours at ${(double)(int)(hourly*100) / 100} per hour.");
            }
            Console.WriteLine($"Gross Pay:                  ${hours*hourly}");
            Console.WriteLine($"Federal withholding:        ${0.15*hours*hourly}");
            Console.WriteLine($"State withholding:          ${0.05 * hours * hourly}");
            Console.WriteLine($"--------------------------------------------------");
            Console.WriteLine($"Net Pay:                    ${(hours * hourly) - (0.15 * hours * hourly) - (0.05 * hours * hourly)}");
        }
    }
}
