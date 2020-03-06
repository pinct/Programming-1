using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Would you like to (1) Calculate Area, (2) Calculate Volume, (3) Calculate Surface Area, (0) Exit Program.");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Calculate Area.");
                    break;
                case 2:
                    Console.WriteLine("Calculate Volume.");
                    break;
                case 3:
                    Console.WriteLine("Calculate Volume.");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Error: Invalid Choice");
                    break;
            }
        }
    }
}
