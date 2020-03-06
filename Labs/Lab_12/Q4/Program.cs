using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 1;
            int num3 = 0;
            int num4 = 0;
            Console.WriteLine($"{num1} {num2} {num3} {num4}");
            Calculate(num1, num2, ref num3, ref num4);
            Console.WriteLine($"{num1} {num2} {num3} {num4}");
        }
        static void Calculate(int num1, int num2, ref int num3, ref int num4)
        {
            num3 = num1 + num2;
            num4 = num1 - num2;
        }
    }
}
