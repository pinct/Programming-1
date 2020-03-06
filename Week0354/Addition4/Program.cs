using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Please input the first number.");
            userInput = Console.ReadLine();
            firstNumber = Convert.ToInt32(userInput);

            Console.WriteLine("Please input the second number.");
            userInput = Console.ReadLine();
            secondNumber = Convert.ToInt32(userInput);

            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber + secondNumber);
            Console.Write("\n");

            Console.Write(firstNumber);
            Console.Write("-");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber - secondNumber);
            Console.Write("\n");

            Console.Write(firstNumber);
            Console.Write("*");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write(firstNumber * secondNumber);
            Console.Write("\n");

            Console.Write(firstNumber);
            Console.Write("/");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.Write((float)firstNumber / (float)secondNumber);
            Console.Write("\n");

            Console.Write("(");
            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write(")/");
            Console.Write(firstNumber);
            Console.Write("=");
            Console.Write(((float)firstNumber + (float)secondNumber) / (float)firstNumber);
            Console.Write("\n");
    }
    }
}
