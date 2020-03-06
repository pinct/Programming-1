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
            string status;
            int courses;
            Console.WriteLine("Are you domestic or international?");
            status = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the number of courses.");
            courses = Convert.ToInt32(Console.ReadLine());
            switch (status)
            {
                case "domestic":
                    Console.WriteLine($"Tuition: {325 * courses}");
                    break;
                case "international":
                    Console.WriteLine($"Tuition: {1375 * courses}");
                    break;
                default:
                    Console.WriteLine($"Invalid residency");
                    break;
            }
        }
    }
}
