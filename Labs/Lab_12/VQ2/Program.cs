using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 31, 50, 80, 22, 32, 12, 52, 87 };
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
                frequency[array[i] / 10] = frequency[array[i] / 10] + 1;
            }
            return frequency;
        }
    }
}
