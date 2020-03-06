using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA;
            double score;
            Console.WriteLine("Enter the GPA.");
            GPA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the admission test score.");
            score = Convert.ToDouble(Console.ReadLine());
            if ((GPA >= 3.0 && score >= 60) || (score >= 80))
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }
    }
}
