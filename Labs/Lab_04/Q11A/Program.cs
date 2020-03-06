using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11A
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            int day;
            Console.WriteLine("Enter the month (1 is Jan, 12 is Dec).");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day.");
            day = Convert.ToInt32(Console.ReadLine());
            if (month > 12 || month < 1)
            {
                Console.WriteLine("Month is invalid");
            }
            if (day > 31 || day < 1)
            {
                Console.WriteLine("Day is invalid");
            }
        }
    }
}
