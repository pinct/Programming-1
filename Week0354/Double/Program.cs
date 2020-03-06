using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double
{
    class Program
    {
        //Inputs two numbers, and then adds, subtracts, multiplies, divides, and perform an operation using the two numbers.
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Please input the first number.");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number.");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{firstNumber} + {secondNumber} = { firstNumber + secondNumber} \n");
            Console.Write($"{firstNumber} - {secondNumber} = { firstNumber - secondNumber} \n");
            Console.Write($"{firstNumber} * {secondNumber} = { firstNumber * secondNumber} \n");
            Console.Write($"{firstNumber} / {secondNumber} = { (double)firstNumber / (double)secondNumber} \n");
            Console.Write($"({firstNumber} + {secondNumber}) / {firstNumber} = { ((double)firstNumber + (double)secondNumber)/firstNumber} \n");
        }
    }
}
