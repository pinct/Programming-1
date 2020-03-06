using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelC_301106259_FinalQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ConvertToBinary(15)}");
        }
        static string ConvertToBinary(int input)
        {
                return Convert.ToString(input, 2);
        }
    }
}
