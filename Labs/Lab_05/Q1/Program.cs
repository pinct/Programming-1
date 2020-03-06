using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay;
            Console.WriteLine("Enter an hourly pay rate.");
            pay = Convert.ToDouble(Console.ReadLine());
            if (pay < 7.50)
            {
                Console.WriteLine("Error: Pay is too low.");
            }
        }
    }
}
