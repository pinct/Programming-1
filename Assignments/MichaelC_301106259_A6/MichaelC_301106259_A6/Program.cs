using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelC_301106259_A6
{
    //Michael Courneya - 301106259
    class Program
    {
        static void Main(string[] args)
        {
            IsPerfect(GetNumber());
        }
        static void IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum != num || num == 0)
            {
                Console.WriteLine($"{num} is not perfect.");
            }
            else if (sum == num)
            {
                Console.WriteLine($"{num} is perfect.");
            }
        }
        static int GetNumber()
        {
            string num = "";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter an integer");
                num = Console.ReadLine();
                for (int i = 0; i < num.Length; i++)
                {
                    if (!("1234567890".Contains(num.Substring(i, 1))))
                    {
                        Console.WriteLine("Invalid Number");
                        break;
                    }
                    else if (i == num.Length - 1)
                    {
                        loop = false;
                    }
                }
            }
            return Convert.ToInt32(num);
        }
    }
}