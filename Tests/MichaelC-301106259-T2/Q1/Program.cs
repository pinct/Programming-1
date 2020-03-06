using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            int max;
            int total = 1;
            int previous;
            Console.WriteLine("Enter a maximum integer.");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i = 3; i < max + 1; i++)
            {
                if (i % 2 != 0)
                {
                    total = total * i;
                }
            }
            Console.WriteLine($"Total product: {total}");
        }
    }
}
