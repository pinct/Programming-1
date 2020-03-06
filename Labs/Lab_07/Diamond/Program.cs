using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 7;
            int stars = 1;
            int half = 0;
            if (height % 2 != 0)
            {
                half = height / 2 + 1;
                for (int i = 0; i < half; i++)
                {
                    for (int j = 0; j < (half - (i + 1)); j++)
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
                for (int i = (half - 2); i >= 0; i--)
                {
                    if (i == (half - 2))
                    {
                        stars = stars - 4;
                    }
                    for (int j = 0; j < (half - (i + 1)); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < stars; j++)
                    {
                        Console.Write("*");
                    }
                    stars = stars - 2;
                    Console.WriteLine("");
                }
            }
            else
            {
                half = height / 2;
                for (int i = 0; i < half; i++)
                {
                    for (int j = 0; j < (half - (i + 1)); j++)
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
                for (int i = (half - 1); i >= 0; i--)
                {
                    if (i == (half - 1))
                    {
                        stars = stars - 2;
                    }
                    for (int j = 0; j < (half - (i + 1)); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < stars; j++)
                    {
                        Console.Write("*");
                    }
                    stars = stars - 2;
                    Console.WriteLine("");
                }
            }
        }
    }
}
