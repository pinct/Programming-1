﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            DoubleIt(ref x);
            Console.WriteLine($"{x}");
        }
        static void DoubleIt (ref int x)
        {
            x = x * 2;
        }
    }
}
