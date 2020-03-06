using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the yard.");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the yard.");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Would you like to pay (1) once, (2) twice, or (3) weekly.");
            int pay = Convert.ToInt32(Console.ReadLine());
            double total = width * length;
            switch (total < 400)
            {
                case true:
                    switch (pay)
                    {
                        case 1:
                            Console.WriteLine($"Total Fee: ${25 * 20}");
                            break;
                        case 2:
                            Console.WriteLine($"Payment fee: ${25*20*.5 + 5}");
                            Console.WriteLine($"Total Fee: ${25 * 20 + 10}");
                            break;
                        case 3:
                            Console.WriteLine("Weekly Fee: $28.00");
                            Console.WriteLine($"Total Fee: ${28 * 20}");
                            break;
                        default:
                            Console.WriteLine("Invalid payment option.");
                            break;
                    }
                    break;
                case false:
                    switch (total >= 600)
                    {
                        case true:
                            switch (pay)
                            {
                                case 1:
                                    Console.WriteLine($"Total Fee: ${50 * 20}");
                                    break;
                                case 2:
                                    Console.WriteLine($"Payment fee: ${50 * 20 * .5 + 5}");
                                    Console.WriteLine($"Total Fee: ${50 * 20 + 10}");
                                    break;
                                case 3:
                                    Console.WriteLine("Weekly Fee: $53.00");
                                    Console.WriteLine($"Total Fee: ${53 * 20}");
                                    break;
                                default:
                                    Console.WriteLine("Invalid payment option.");
                                    break;
                            }
                            break;
                        case false:
                            switch (pay)
                            {
                                case 1:
                                    Console.WriteLine($"Total Fee: ${35 * 20}");
                                    break;
                                case 2:
                                    Console.WriteLine($"Payment fee: ${35 * 20 * .5 + 5}");
                                    Console.WriteLine($"Total Fee: ${35 * 20 + 10}");
                                    break;
                                case 3:
                                    Console.WriteLine("Weekly Fee: $38.00");
                                    Console.WriteLine($"Total Fee: ${38 * 20}");
                                    break;
                                default:
                                    Console.WriteLine("Invalid payment option.");
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
