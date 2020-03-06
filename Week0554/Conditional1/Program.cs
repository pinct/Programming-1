using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number > 50)
            {
                Console.WriteLine($"{number} is greater than 50");
            }
            else if (number == 50)
            {
                Console.WriteLine($"{number} is equal to 50");
            }
            else
            {
                Console.WriteLine($"{number} is less than 50");
            }
        }
    }
}
