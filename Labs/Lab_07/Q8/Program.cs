using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input = 0;
            int nums = 0;
            while (sum < 100)
            {
                Console.WriteLine("Enter a value to add.");
                input = Convert.ToInt32(Console.ReadLine());
                sum = sum + input;
                nums = nums + 1;
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avg input = {sum/nums}");
        }
    }
}
