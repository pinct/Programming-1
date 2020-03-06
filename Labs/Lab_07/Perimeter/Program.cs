﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 6;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == (height - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 0 || j == (width - 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
