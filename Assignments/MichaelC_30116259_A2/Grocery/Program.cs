using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery
{
    class Program
    {
        //Michael Courneya - 301106259 - 004
        static void Main(string[] args)
        {
            Console.WriteLine("Input price of produce.");
            double produce = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input weight of produce in kg.");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input price of bag.");
            double bag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input capacity of bag in kg.");
            double capacity = Convert.ToDouble(Console.ReadLine());
            if ((int)(weight / capacity) != (weight / capacity))
            {
                Console.WriteLine($"The total price is {produce * weight + ((int)(weight / capacity) + 1) * bag}");
            }
            else
            {
                Console.WriteLine($"The total price is {produce * weight + ((int)(weight / capacity)) * bag}");
            }
        }
    }
}
