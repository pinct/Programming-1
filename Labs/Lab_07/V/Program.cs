using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 7;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < ((height - (i + 1)) * 2); j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
