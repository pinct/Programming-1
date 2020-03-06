using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessAWord
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            string[] wordbank = { "luxury", "deadpan", "fireball", "introvert", "bohemian", "rocket", "american", "inquiry" };
            Random rand = new Random();
            int randomWord = rand.Next(0, 9);
            string hiddenWord = wordbank[randomWord].ToLower();
            char[] asterisks = new char[hiddenWord.Length];
            bool solved = false;
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                asterisks[i] = '*';
            }
            Console.WriteLine("Guess a Word");
            Console.Write("Word: ");
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                Console.Write($"{asterisks[i]}");
            }
            Console.WriteLine("");
            while (!solved)
            {
                Console.Write("Guess a letter >> ");
                char guess = Convert.ToChar(Console.ReadLine().ToLower());
                bool correct = false;
                for (int i = 0; i < hiddenWord.Length; i++)
                {
                    if (hiddenWord[i] == guess)
                    {
                        asterisks[i] = guess;
                        correct = true;
                    }
                }
                if (!correct)
                {
                    Console.WriteLine($"Sorry. {guess} is not in the word.");
                }
                else
                {
                    solved = true;
                    Console.Write("Word: ");
                    for (int i = 0; i < hiddenWord.Length; i++)
                    {
                        Console.Write($"{asterisks[i]}");
                        if (asterisks[i] == '*')
                        {
                            solved = false;
                        }
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Puzzle Solved!");
        }
    }
}
