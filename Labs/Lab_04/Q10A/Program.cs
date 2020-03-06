using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10A
{
    class Program
    {
        static void Main(string[] args)
        {
            char stat;
            Console.WriteLine("Enter 'u' of you are happy.");
            stat = Convert.ToChar(Console.ReadLine());
            if (stat == 'u')
            {
                Console.WriteLine("I feel great today!");
            }
            else
            {
                Console.WriteLine("I feel down today.");
            }
        }
    }
}
