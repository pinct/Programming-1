using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ
{
    //Michael Courneya - 301106259 - 004
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an IQ score.");
            int IQ = Convert.ToInt32(Console.ReadLine());
            if (IQ > 200 || IQ < 0)
            {
                Console.WriteLine("IQ entered is invalid.");
            }
            else if (IQ > 100)
            {
                Console.WriteLine("IQ entered is above average.");
            }
            else if (IQ == 100)
            {
                Console.WriteLine("IQ entered is average.");
            }
            else
            {
                Console.WriteLine("IQ entered is below average.");
            }
        }
    }
}
