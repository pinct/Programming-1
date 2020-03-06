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
            double width;
            double length;
            double lot;
            double pay;
            Console.WriteLine("Enter the lot width in ft.");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the lot length in ft.");
            length = Convert.ToDouble(Console.ReadLine());
            lot = width * length;
            Console.WriteLine("Would you like to pay (1) once, (2) twice, or (3) twenty times per season.");
            pay = Convert.ToInt32(Console.ReadLine());
            if (lot < 400)
            {
                if (pay == 1)
                {
                    Console.WriteLine($"Total Fee: ${25 * 20}");
                }
                else if (pay == 2)
                {
                    Console.WriteLine($"Half Fee: ${25 * 20 * .5 + 5}");
                    Console.WriteLine($"Total Fee: ${25 * 20 + 10}");
                }
                else
                {
                    Console.WriteLine($"Weekly Fee: ${25 + 3}");
                    Console.WriteLine($"Total Fee: ${25 * 20 + 3 * 20}");
                }
            }
            else if (lot >= 600)
            {
                if (pay == 1)
                {
                    Console.WriteLine($"Total Fee: ${50 * 20}");
                }
                else if (pay == 2)
                {
                    Console.WriteLine($"Half Fee: ${50 * 20 * .5 + 5}");
                    Console.WriteLine($"Total Fee: ${50 * 20 + 10}");
                }
                else
                {
                    Console.WriteLine($"Weekly Fee: ${50 + 3}");
                    Console.WriteLine($"Total Fee: ${50 * 20 + 3 * 20}");
                }
            }
            else
            {
                if (pay == 1)
                {
                    Console.WriteLine($"Total Fee: ${35 * 20}");
                }
                else if (pay == 2)
                {
                    Console.WriteLine($"Half Fee: ${35 * 20 * .5 + 5}");
                    Console.WriteLine($"Total Fee: ${35 * 20 + 10}");
                }
                else
                {
                    Console.WriteLine($"Weekly Fee: ${35 + 3}");
                    Console.WriteLine($"Total Fee: ${35 * 20 + 3 * 20}");
                }
            }
        }
    }
}
