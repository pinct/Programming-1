using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Enter a day of the week (3 Letters)");
            choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "sun":
                    Console.WriteLine("Home");
                    break;
                case "mon":
                    Console.WriteLine("Work.");
                    break;
                case "tue":
                    Console.WriteLine("Work.");
                    break;
                case "wed":
                    Console.WriteLine("Home");
                    break;
                case "thu":
                    Console.WriteLine("Work.");
                    break;
                case "fri":
                    Console.WriteLine("Work.");
                    break;
                case "sat":
                    Console.WriteLine("Work.");
                    break;
                default:
                    Console.WriteLine("Error: Invalid Choice");
                    break;
            }
        }
    }
}
