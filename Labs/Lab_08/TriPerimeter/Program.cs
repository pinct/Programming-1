using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 6;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < (height - i); j++)
                {
                    Console.Write(" ");
                }
                if (i == height - 1)
                {
                    for (int j = 0; j < (height*2); j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int j = 0; j < (i*2); j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
