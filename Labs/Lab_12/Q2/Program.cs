using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int cube = 0;
            CubeIt(x, ref cube);
            Console.WriteLine($"{cube}");
        }
        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
    }
}
