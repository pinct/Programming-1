using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Enter the message.");
            text = Console.ReadLine();
            if (text.Length > 140)
            {
                Console.WriteLine("Message is too long.");
            }
        }
    }
}
