﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            double choice;
            Console.WriteLine("Enter pay rate.");
            choice = Convert.ToDouble(Console.ReadLine());
            switch (choice < 5.56)
            {
                case true:
                    Console.WriteLine("Invalid Pay rate");
                    break;
                default:
                    Console.WriteLine("Valid Pay Rate");
                    break;
            }
        }
    }
}
