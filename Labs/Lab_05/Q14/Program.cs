using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;
            Random random = new Random();
            int randNum1 = random.Next(1, 5);
            int randNum2 = random.Next(1, 5);
            int randNum3 = random.Next(1, 5);
            Console.WriteLine("Enter first number between 1 and 4.");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number between 1 and 4.");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number between 1 and 4.");
            third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Guess: {first}{second}{third}.");
            Console.WriteLine($"Winning Numbers: {randNum1}{randNum2}{randNum3}.");
            if (first == randNum1)
            {
                if (second == randNum2)
                {
                    if (third == randNum3)
                    {
                        Console.WriteLine($"You win: $10,000.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                }
                else if (third == randNum2)
                {
                    if (second == randNum3)
                    {
                        Console.WriteLine($"You win: $1,000.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                }
                else if (second == randNum3)
                {
                    Console.WriteLine($"You win: $100.");
                }
                else if (third == randNum3)
                {
                    Console.WriteLine($"You win: $100.");
                }
                else
                {
                    Console.WriteLine($"You win: $10.");
                }
            }
            else if (second == randNum1)
            {
                if (first == randNum2)
                {
                    if (third == randNum3)
                    {
                        Console.WriteLine($"You win: $1,000.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                }
                else if (third == randNum2)
                {
                    if (first == randNum3)
                    {
                        Console.WriteLine($"You win: $1,000.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                }
                else if (first == randNum3)
                {
                    Console.WriteLine($"You win: $100.");
                }
                else if (third == randNum3)
                {
                    Console.WriteLine($"You win: $100.");
                }
                else
                {
                    Console.WriteLine($"You win: $10.");
                }
            }
            else if (third == randNum1)
            {
                if (first == randNum2)
                {
                    if (second == randNum3)
                    {
                        Console.WriteLine($"You win: $1,000.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                }
                else if (second == randNum2)
                {
                    if (first == randNum3)
                    {
                        Console.WriteLine($"You win: $1,000.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                }
                else if (first == randNum3)
                {
                    Console.WriteLine($"You win: $100.");
                }
                else if (second == randNum3)
                {
                    Console.WriteLine($"You win: $100.");
                }
                else
                {
                    Console.WriteLine($"You win: $10.");
                }
            }
            else
            {
                if (first == randNum2)
                {
                    if (second == randNum3)
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                    else if (third == randNum3)
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $10.");
                    }
                }
                else if (second == randNum2)
                {
                    if (first == randNum3)
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                    else if (third == randNum3)
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $10.");
                    }
                }
                else if (third == randNum2)
                {
                    if (first == randNum3)
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                    else if (second == randNum3)
                    {
                        Console.WriteLine($"You win: $100.");
                    }
                    else
                    {
                        Console.WriteLine($"You win: $10.");
                    }
                }
                else if (first == randNum3)
                {
                    Console.WriteLine($"You win: $10.");
                }
                else if (second == randNum3)
                {
                    Console.WriteLine($"You win: $10.");
                }
                else if (third == randNum3)
                {
                    Console.WriteLine($"You win: $10.");
                }
                else
                {
                    Console.WriteLine($"You win: $0.");
                }
            }
        }
    }
}
