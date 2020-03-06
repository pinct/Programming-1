using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string domestic;
            int courses;
            Console.WriteLine("Are you a domestic student? (Y/N)");
            domestic = (Console.ReadLine()).ToUpper();
            Console.WriteLine("How many courses are you taking?");
            courses = Convert.ToInt32(Console.ReadLine());
            if (domestic == "Y")
            {
                if (courses < 4)
                {
                    Console.WriteLine($"Tuition: ${courses * 425}.00");
                }
                else
                {
                    Console.WriteLine($"Tuition: ${courses * 350}.00");
                }
            }
            else
            {
                if (courses < 4)
                {
                    Console.WriteLine($"Tuition: ${courses * 1225}.00");
                }
                else
                {
                    Console.WriteLine($"Tuition: ${courses * 1175}.00");
                }
            }
        }
    }
}
