using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelC_301106259_Q5
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            int number = 2;
            double cost = 350.2;
            Console.WriteLine($"{CalculateTuitionFee(number, cost)}");
            number = 3;
            cost = 405.5;
            Console.WriteLine($"{CalculateTuitionFee(number, cost)}");
            number = 1;
            cost = 500.2;
            Console.WriteLine($"{CalculateTuitionFee(number, cost)}");
            number = 5;
            cost = 101.3;
            Console.WriteLine($"{CalculateTuitionFee(number, cost)}");
        }
        static double CalculateTuitionFee(int numberOfCourses, double costPerCourse)
        {
            return numberOfCourses * costPerCourse + 15.25;
        }
    }
}
