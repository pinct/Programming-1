using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLowAndHighRate
{
    //Michael Courneya - 301106259 - 004
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an hourly pay rate.");
            double rate = Convert.ToDouble(Console.ReadLine());
            if (rate < 7.50 || rate > 49.99)
            {
                Console.WriteLine("Hourly rate is invalid.");
            }
            else
            {
                Console.WriteLine("Hourly rate is valid.");
            }
        }
    }
}
