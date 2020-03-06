using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 8, 2, 3, 1, 5, 8 };
            int[] frequency = CalculateDigitFrequencies(array);
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine($"{frequency[i]}");
            }
        }
        static int[] CalculateDigitFrequencies(int[] array)
        {
            int[] frequency = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < array.Length; i++)
            {
                frequency[array[i]] = frequency[array[i]] + 1;
            }
            return frequency;
        }
    }
}
