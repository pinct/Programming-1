using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionary
{
    class Program
    {
        //Michael Courneya - 301106259 - 004
        static void Main(string[] args)
        {
            Console.WriteLine("What is the price of the candy?");
            double price;
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your budget?");
            double budget;
            budget = Convert.ToDouble(Console.ReadLine());
            if (budget != 0)
            {
                Console.WriteLine($"You can buy {(int)(budget / price)} candies");
            }
            else
            {
                Console.WriteLine($"You can buy 0 candies");
            }
        }
    }
}
