using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            Random random = new Random();
            int randNum = random.Next(1, 11);
            Console.WriteLine("Guess a number between 1 and 10.");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == randNum)
            {
                Console.WriteLine("Guess was correct.");
            }
            else if (guess > randNum)
            {
                Console.WriteLine("Guess was too high.");
            }
            else
            {
                Console.WriteLine("Guess was too low.");
            }
        }
    }
}
