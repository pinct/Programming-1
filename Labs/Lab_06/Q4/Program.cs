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
            double IQ;
            Console.WriteLine("Enter an IQ score.");
            IQ = Convert.ToDouble(Console.ReadLine());
            switch (IQ < 0 || IQ > 200)
            {
                case (true):
                    Console.WriteLine("IQ is invalid.");
                    break;
                case (false):
                    if (IQ == 100)
                    {
                        Console.WriteLine("IQ is average.");
                    }
                    else if (IQ < 100)
                    {
                        Console.WriteLine("IQ is below average.");
                    }
                    else
                    {
                        Console.WriteLine("IQ is above average.");
                    }
                    break;
            }
        }
    }
}
