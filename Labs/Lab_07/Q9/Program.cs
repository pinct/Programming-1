using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 1000000; i < 2000000; i++)
            {
                if (i%3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
