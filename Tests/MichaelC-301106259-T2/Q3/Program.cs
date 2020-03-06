using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            string phrase;
            int count = 0;
            Console.WriteLine("Enter a phrase.");
            phrase = Console.ReadLine().ToLower();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u')
                {
                    count = count + 1;
                }
            }
            Console.WriteLine($"There are {count} vowel(s) in the phrase.");
        }
    }
}
