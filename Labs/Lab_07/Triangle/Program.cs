using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 6;
            int stars = 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < (height - (i + 1)); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }
                stars = stars + 2;
                Console.WriteLine("");
            }
        }
    }
}
