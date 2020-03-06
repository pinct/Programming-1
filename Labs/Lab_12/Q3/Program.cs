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
            int num = 3;
            double cost = 4;
            double fees = 0;
            CaculateTuitionFee(num, cost, ref fees);
            Console.WriteLine($"{fees}");
        }
        static void CaculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15;
        }
    }
}
