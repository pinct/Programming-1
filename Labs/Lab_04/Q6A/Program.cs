using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6A
{
    class Program
    {
        static void Main(string[] args)
        {
            int years;
            Console.WriteLine("Enter the number of years money was depositied.");
            years = Convert.ToInt32(Console.ReadLine());
            if (years > 5)
            {
                Console.WriteLine("The interest rate is 7.5%");
            }
            else
            {
                Console.WriteLine("The interest rate is 5.4%");
            }
        }
    }
}
