using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double price;
            Console.WriteLine("Enter two letter province code");
            choice = Console.ReadLine().ToLower();
            Console.WriteLine("Enter price of the item");
            price = Convert.ToDouble(Console.ReadLine());
            switch (choice)
            {
                case "on":
                    Console.WriteLine($"Price is ${1.14 * price}");
                    break;
                case "pq":
                    Console.WriteLine($"Price is ${1.13 * price}");
                    break;
                default:
                    Console.WriteLine($"Price is ${price}");
                    break;
            }
        }
    }
}
