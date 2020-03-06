using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            string[] obama = { "Barack", "Hussein", "Obama" };
            PrintArray(obama);
            PrintArray(poem);
            SumOfPrimes(primes);
            DoublePrimes(primes);
            SumOfPrimes(primes);
            PrintChar(vowels);
            Subtract32(vowels);
            PrintChar(vowels);
            Console.WriteLine($"Sum: {SumOfPrimesNew(primes)}");
        }
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
        static void SumOfPrimes(int[] primes)
        {
            int sum = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                sum = sum + primes[i];
            }
            Console.WriteLine($"Sum: {sum}");
        }
        static void DoublePrimes(int[] primes)
        {
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = primes[i] * 2;
            }
        }
        static void Subtract32(char[] vowels)
        {
            for (int i = 0; i < vowels.Length; i++)
            {
                vowels[i] = (char)((int)vowels[i] - 32);
            }
        }
        static void PrintChar(char[] vowels)
        {
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write($"{vowels[i]} ");
            }
            Console.WriteLine("");
        }
        static int SumOfPrimesNew(int[] primes)
        {
            int sum = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                sum = sum + primes[i];
            }
            return sum;
        }
    }
}
