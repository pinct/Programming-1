using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 6;
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
