using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 28000;
            int DEPRECIATION = 4000;
            int counter = 0;
            int acc = 0;
            Console.WriteLine("{0, 10}{1, 15}{2, 15}{3, 30}", "Year", "Depreciation", "EOY Value", "Accumulated Depreciation");
            Console.WriteLine("{0, 10}{1, 15}{2, 15}{3, 30}", "----------", "----------", "----------", "----------");
            while (value != 0)
            {
                value = value - DEPRECIATION;
                counter = counter + 1;
                acc = acc + DEPRECIATION;
                Console.WriteLine("{0, 10}{1, 15}{2, 15}{3, 30}", counter, DEPRECIATION, value, acc);
            }
        }
    }
}
