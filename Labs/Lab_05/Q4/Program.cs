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
            double pay;
            Console.WriteLine("Enter an hourly pay rate.");
            pay = Convert.ToDouble(Console.ReadLine());
            if (pay < 7.50 || pay > 49.99)
            {
                Console.WriteLine("Enter an hourly pay rate.");
                pay = Convert.ToDouble(Console.ReadLine());
                if (pay < 7.50 || pay > 49.99)
                {
                    Console.WriteLine("Error: Pay is invalid.");
                }
                else
                {
                    Console.WriteLine($"Hourly: ${pay}. Weekly: ${pay*40}.");
                }
            }
            else
            {
                Console.WriteLine($"Hourly: ${pay}. Weekly: ${pay*40}");
            }
        }
    }
}
