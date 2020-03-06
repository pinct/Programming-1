using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        //Michael Courneya - 301106259 - 004
        static void Main(string[] args)
        {
            double s1 = 93.23;
            double s2 = 83;
            double s3 = 73;
            double s4 = 63;
            double s5 = 54;
            double average;

            average = (s1 + s2 + s3 + s4 + s5) / 5;

            Console.WriteLine($"The average is {(double)((int)(average * 100)) / 100}");
        }
    }
}
