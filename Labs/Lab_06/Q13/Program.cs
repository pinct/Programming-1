using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA;
            Console.WriteLine("Enter GPA.");
            GPA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter test score.");
            double score = Convert.ToDouble(Console.ReadLine());
            switch (GPA >= 3.0 && score >= 60)
            {
                case true:
                    Console.WriteLine("Accept.");
                    break;
                default:
                    switch (score >= 80)
                    {
                        case true:
                            Console.WriteLine("Accept.");
                            break;
                        default:
                            Console.WriteLine("Reject.");
                            break;
                    }
                    break;
            }
        }
    }
}
