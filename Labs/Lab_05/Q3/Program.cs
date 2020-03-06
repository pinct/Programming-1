using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            double years;
            Console.WriteLine("Enter the number of years money has been deposited.");
            years = Convert.ToDouble(Console.ReadLine());
            if (years > 5)
            {
                Console.WriteLine("Interest rate is 7.5%.");
            }
            else
            {
                Console.WriteLine("Interest rate is 5.4%.");
            }
        }
    }
}
