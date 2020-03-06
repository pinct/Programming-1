using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7A
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade;
            Console.WriteLine("Enter a grade.");
            grade = Convert.ToDouble(Console.ReadLine());
            if (grade >= 70)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
