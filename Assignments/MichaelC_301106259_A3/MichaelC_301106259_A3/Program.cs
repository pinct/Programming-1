using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelC_301106259_A3
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            int guess = 0;
            int minGuess = 0;
            int maxGuess = 0;
            int counter = 1;
            Random ranNumberGenerator = new Random();
            int randNum;
            Console.WriteLine("Enter a minimum number.");
            min = Convert.ToInt32(Console.ReadLine());
            while (min <= 0)
            {
                Console.WriteLine("Minimum number must be greater than 0.");
                Console.WriteLine("Enter a minimum number.");
                min = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter a maximum number.");
            max = Convert.ToInt32(Console.ReadLine());
            while (max <= min)
            {
                Console.WriteLine("The maximum must be more than the minimum.");
                Console.WriteLine("Enter a maximum number.");
                max = Convert.ToInt32(Console.ReadLine());
            }
            randNum = ranNumberGenerator.Next(min, (max + 1));

            Console.WriteLine("Enter a guess.");
            guess = Convert.ToInt32(Console.ReadLine());
            while (guess != randNum)
            {
                if (guess > randNum)
                {
                    if (maxGuess != 0 && guess > maxGuess)
                    {
                        if (guess > max)
                        {
                            Console.WriteLine("Guess too high");
                            Console.WriteLine($"Guess is higher than previous guess of {maxGuess}");
                            Console.WriteLine($"Guess is higher than the maximum of {max}");
                            Console.WriteLine("Enter a new guess.");
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Guess too high");
                            Console.WriteLine($"Guess is higher than previous guess of {maxGuess}");
                            Console.WriteLine("Enter a new guess.");
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        if (guess > max)
                        {
                            Console.WriteLine("Guess too high");
                            Console.WriteLine($"Guess is higher than the maximum of {max}");
                            Console.WriteLine("Enter a new guess.");
                            maxGuess = guess;
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Guess too high");
                            Console.WriteLine("Enter a new guess.");
                            maxGuess = guess;
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    if (minGuess != 0 && guess < minGuess)
                    {
                        if (guess < min)
                        {
                            Console.WriteLine("Guess too low");
                            Console.WriteLine($"Guess is lower than previous guess of {minGuess}");
                            Console.WriteLine($"Guess is lower than the minimum of {min}");
                            Console.WriteLine("Enter a new guess.");
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Guess too low");
                            Console.WriteLine($"Guess is lower than previous guess of {minGuess}");
                            Console.WriteLine("Enter a new guess.");
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        if (guess < min)
                        {
                            Console.WriteLine("Guess too low");
                            Console.WriteLine($"Guess is lower than the minimum of {min}");
                            Console.WriteLine("Enter a new guess.");
                            minGuess = guess;
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Guess too low");
                            Console.WriteLine("Enter a new guess.");
                            minGuess = guess;
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                counter = counter + 1;
            }
            Console.WriteLine($"Correct! It took {counter} guesses.");
        }
    }
}