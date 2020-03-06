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
            string phrase;
            int[] alpha = new int[26];
            Console.WriteLine("Input a phrase.");
            phrase = Console.ReadLine().ToUpper();
            int[] phraseAsNum = new int[phrase.Length];
            for (int i = 0; i < phrase.Length; i++)
            {
                if (((int)phrase[i] - 64) < 27 && ((int)phrase[i] - 64) > 0)
                {
                    phraseAsNum[i] = (int)phrase[i] - 64;
                }
            }
            for (int i = 1; i < 26; i++)
            {
                int count = 0;
                for (int f = 0; f < phraseAsNum.Length; f++)
                {
                    if (i == phraseAsNum[f])
                    {
                        count = count + 1;
                    }
                }
                alpha[i - 1] = count;
            }
        }
    }
}
