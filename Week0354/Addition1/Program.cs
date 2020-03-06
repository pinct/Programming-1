using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Please input the first number.");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number.");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber + secondNumber);

            Console.Write(firstNumber);
            Console.Write("-");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber - secondNumber);

            Console.Write(firstNumber);
            Console.Write("*");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber * secondNumber);

            Console.Write(firstNumber);
            Console.Write("/");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber / secondNumber);
        }
    }
}
