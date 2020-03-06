using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumberUserInput;
            int firstNumber;
            string secondNumberUserInput;
            int secondNumber;

            Console.WriteLine("Please input the first number.");
            firstNumberUserInput = Console.ReadLine();
            firstNumber = Convert.ToInt32(firstNumberUserInput);

            Console.WriteLine("Please input the second number.");
            secondNumberUserInput = Console.ReadLine();
            secondNumber = Convert.ToInt32(secondNumberUserInput);

            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber + secondNumber);
        }
    }
}
