using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelC_301106259_A5
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            string word;
            string allWords = "";
            Console.WriteLine("Enter a word.");
            word = Console.ReadLine();
            do
            {
                if (IsPalindrome(word))
                {
                    if (ContainsChar(word) && ContainsNums(word))
                    {
                        Console.WriteLine($"{word} is an alphanumeric palindrome.");
                    }
                    else if (ContainsChar(word))
                    {
                        Console.WriteLine($"{word} is an alphabetic palindrome.");
                    }
                    else if (ContainsNums(word))
                    {
                        Console.WriteLine($"{word} is an numeric palindrome.");
                    }
                    allWords = $"{word} {allWords}";
                }
                else
                {
                    Console.WriteLine("Is not a palindrome.");
                }

                Console.WriteLine("Enter a word.");
                word = Console.ReadLine();
            } while (word.ToLower() != "end");
            Console.WriteLine($"{allWords}");
        }
        static bool IsPalindrome(string word)
        {
            string[] palindrome = new string[word.Length];
            bool isPalindrome = true;
            for (int i = 0; i < word.Length; i++)
            {
                palindrome[i] = word.Substring(i, 1).ToLower();
            }
            for (int i = 0; i < (palindrome.Length / 2); i++)
            {
                if (palindrome[i] != palindrome[palindrome.Length - (i + 1)])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
        static bool ContainsNums(string word)
        {
            bool containsNums = false;
            for (int i = 0; i < word.Length; i++)
            {
                if ("1234567890".Contains(word.Substring(i, 1)))
                {
                    containsNums = true;
                }
            }
            return containsNums;
        }
        static bool ContainsChar(string word)
        {
            bool containsChar = false;
            for (int i = 0; i < word.Length; i++)
            {
                if ("abcdefghijklmnopqrstuvwxyz".Contains(word.Substring(i, 1).ToLower()))
                {
                    containsChar = true;
                }
            }
            return containsChar;
        }
    }
}
