using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber
{
    //Michael Courneya - 301106259 - 004
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of the job.");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input price per unit of length.");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input number of joins.");
            int joins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input price per join.");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The total price is {length*price + joins*price2}");
        }
    }
}
