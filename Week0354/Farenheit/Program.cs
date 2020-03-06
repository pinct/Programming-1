using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            float temp;

            Console.WriteLine("Please input the temperature in Fahrenheit.");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            temp = firstNumber;

            Console.Write($"{firstNumber} degrees Fahrenheit = { (temp - 32) * (5.0/9.0)} degrees Celcius\n");
        }
    }
}
