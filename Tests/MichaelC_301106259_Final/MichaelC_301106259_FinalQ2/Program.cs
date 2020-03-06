using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelC_301106259_FinalQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 09, 08, 13, 30, 38, 45, 68, 99 };
            int[] output = CalculateNumberFrequencies(input);
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($"{output[i]}");
            }
        }
        static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] output = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < array.Length; i++)
            {
                output[array[i]/10] = output[array[i]/10] + 1;
            }
            return output;
        }
    }
}
