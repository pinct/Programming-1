using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            char operation;
            Console.WriteLine("Enter the first integer.");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer.");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation (A, S, or M).");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case 'A':
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;
                case 'S':
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;
                case 'M':
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;
                default:
                    Console.WriteLine($"Unknown Operation.");
                    break;
            }
        }
    }
}
