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
            int a = 10, b = 5, result;
            char operation = '+';
            if (Method(a, b, operation, out result))
            {
                Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
            }
            operation = '*';
            if (Method(a, b, operation, out result))
            {
                Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
            }
            operation = '&';
            if (Method(a, b, operation, out result))
            {
                Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
            }
        }
        static bool Method(int num1, int num2, char letter, out int num3)
        {
            if (letter == '+')
            {
                num3 = num1 + num2;
                return true;
            }
            else if (letter == '-')
            {
                num3 = num1 - num2;
                return true;
            }
            else if (letter == '*')
            {
                num3 = num1 * num2;
                return true;
            }
            else if (letter == '/')
            {
                num3 = num1 / num2;
                return true;
            }
            else
            {
                Console.WriteLine($"Invalid Operator");
                num3 = -1;
                return false;
            }
        }
    }
}
