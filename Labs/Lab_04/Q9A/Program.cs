using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9A
{
    class Program
    {
        static void Main(string[] args)
        {
            char stat;
            Console.WriteLine("Enter status (S/J)");
            stat = Convert.ToChar(Console.ReadLine());
            if (stat == 'S')
            {
                Console.WriteLine("Salary is $400 per week");
            }
            else
            {
                Console.WriteLine("Salary is $275 per week");
            }
        }
    }
}
