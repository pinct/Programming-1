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
            double width;
            double length;
            Console.WriteLine("Enter the lot width in ft.");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the lot length in ft.");
            length = Convert.ToDouble(Console.ReadLine());
            double lot = width * length;
            if (lot < 400)
            {
                Console.WriteLine($"Weekly Fee: $25.00");
                Console.WriteLine($"Total Fee: ${25*20}");
            }
            else if (lot >= 600)
            {
                Console.WriteLine($"Weekly Fee: $50.00");
                Console.WriteLine($"Total Fee: ${50 * 20}");
            }
            else
            {
                Console.WriteLine($"Weekly Fee: $35.00");
                Console.WriteLine($"Total Fee: ${35 * 20}");
            }
        }
    }
}
