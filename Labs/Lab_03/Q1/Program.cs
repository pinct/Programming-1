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
            double firstNum;
            string operation;
            double secondNum;
            Console.WriteLine("Enter the first number.");
            firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operation.");
            operation = Console.ReadLine();
            Console.WriteLine("Enter the second number.");
            secondNum= Convert.ToDouble(Console.ReadLine());
            if (operation == "+")
            {
                Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
            }
            else
            {
                Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
            }
        }
    }
}
