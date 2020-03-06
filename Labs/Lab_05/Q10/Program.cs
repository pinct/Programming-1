using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            double IQ;
            Console.WriteLine("Enter an IQ score.");
            IQ = Convert.ToDouble(Console.ReadLine());
            if (IQ < 0 || IQ > 200)
            {
                Console.WriteLine("Error: Invalid IQ");
            }
            else
            {
                if (IQ < 100)
                {
                    Console.WriteLine("Below Average.");
                }
                else if (IQ == 100)
                {
                    Console.WriteLine("Average.");
                }
                else
                {
                    Console.WriteLine("Above Average.");
                }
            }
        }
    }
}
