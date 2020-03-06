using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Pine, Oak or Mahogany?");
            choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "pine":
                    Console.WriteLine("Price is $100");
                    break;
                case "oak":
                    Console.WriteLine("Price is $225");
                    break;
                case "mahogany":
                    Console.WriteLine("Price is $310");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
