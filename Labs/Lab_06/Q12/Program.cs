using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            double choice;
            Console.WriteLine("Enter pay rate.");
            choice = Convert.ToDouble(Console.ReadLine());
            switch (choice < 5.56 || choice > 49.99)
            {
                case true:
                    Console.WriteLine("Enter pay rate.");
                    choice = Convert.ToDouble(Console.ReadLine());
                    switch (choice < 5.56 || choice > 49.99)
                    {
                        case true:
                            Console.WriteLine("Invalid Pay rate");
                            break;
                        default:
                            Console.WriteLine($"Pay rate: {choice}. Weekly Pay Rate: {choice * 40}");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"Pay rate: {choice}. Weekly Pay Rate: {choice * 40}");
                    break;
            }
        }
    }
}
