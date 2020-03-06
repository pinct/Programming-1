using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            string province;
            Console.WriteLine("Enter your province code.");
            province = Console.ReadLine().ToLower();
            if (province == "on")
            {
                Console.WriteLine("You live in Ontario.");
            }
            else
            {
                Console.WriteLine("You do not live in Ontario.");
            }
        }
    }
}
