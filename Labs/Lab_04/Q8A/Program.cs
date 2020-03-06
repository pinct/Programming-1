using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8A
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours;
            Console.WriteLine("Enter the number of hours.");
            hours = Convert.ToInt32(Console.ReadLine());
            if (hours > 40)
            {
                Console.WriteLine($"Total Pay: ${320 + 12 * (hours - 40)}");
            }
            else
            {
                Console.WriteLine($"Totale Pay: ${hours * 8}");
            }
        }
    }
}
