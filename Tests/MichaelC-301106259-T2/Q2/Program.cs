using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            int size = 0;
            Console.WriteLine("Enter the number of rows.");
            size = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < (size - (i + 1)); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
