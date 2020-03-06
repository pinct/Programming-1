using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Chicken 1's egg count");
            double chicken1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Chicken 2's egg count");
            double chicken2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Chicken 3's egg count");
            double chicken3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Chicken 4's egg count");
            double chicken4 = Convert.ToDouble(Console.ReadLine());
            double total = (chicken1 + chicken2 + chicken3 + chicken4);
            int dozens = ((int)total) / 12;
            double eggs = total - (dozens * 12);
            Console.WriteLine($"The total amount is {dozens} dozen and {eggs} eggs");
        }
    }
}
