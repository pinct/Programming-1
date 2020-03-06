using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius = 0;
            while (Celcius <= 100)
            {
                Console.WriteLine($"Celcius: {Celcius}      Fahrenheit: {((Celcius * 9) / 5) + 32}");
                Celcius = Celcius + 10;
            }
        }
    }
}
