using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the yard.");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the yard.");
            double width = Convert.ToDouble(Console.ReadLine());
            double total = width * length;
            switch (total < 400)
            {
                case true:
                    Console.WriteLine("Weekly Fee: $25.00");
                    Console.WriteLine($"Total Fee: ${25 * 20}");
                    break;
                case false:
                    switch (total >= 600)
                    {
                        case true:
                            Console.WriteLine("Weekly Fee: $50.00");
                            Console.WriteLine($"Total Fee: ${50 * 20}");
                            break;
                        case false:
                            Console.WriteLine("Weekly Fee: $35.00");
                            Console.WriteLine($"Total Fee: ${35 * 20}");
                            break;
                    }
                    break;
            }
        }
    }
}
