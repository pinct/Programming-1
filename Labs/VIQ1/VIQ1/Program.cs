using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "ABCDabcd";
            Console.WriteLine($"{Encrypt(message, -2)}");
            Console.WriteLine($"{Decrypt(message, -2)}");
        }
        static string Encrypt(string input, int shift)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int charNum = (int)array[i];
                if (charNum > 64 && charNum < 91)
                {
                    if (charNum + shift > 64 && charNum + shift < 91)
                    {
                        array[i] = (char)(charNum + shift);
                    }
                    else if (charNum + shift <= 64)
                    {
                        while (charNum + shift <= 64)
                        {
                            shift = shift + 26;
                        }
                        array[i] = (char)(charNum + shift);
                    }
                    else if (charNum + shift >= 91)
                    {
                        while (charNum + shift >= 91)
                        {
                            shift = shift - 26;
                        }
                        array[i] = (char)(charNum + shift);
                    }
                }
                else if (charNum > 96 && charNum < 123)
                {
                    if (charNum + shift > 96 && charNum + shift < 123)
                    {
                        array[i] = (char)(charNum + shift);
                    }
                    else if (charNum + shift <= 96)
                    {
                        while (charNum + shift <= 96)
                        {
                            shift = shift + 26;
                        }
                        array[i] = (char)(charNum + shift);
                    }
                    else if (charNum + shift >= 123)
                    {
                        while (charNum + shift >= 123)
                        {
                            shift = shift - 26;
                        }
                        array[i] = (char)(charNum + shift);
                    }
                }
            }
            return new string(array);
        }
        static string Decrypt(string input, int shift)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int charNum = (int)array[i];
                if (charNum > 64 && charNum < 91)
                {
                    if (charNum - shift > 64 && charNum - shift < 91)
                    {
                        array[i] = (char)(charNum - shift);
                    }
                    else if (charNum - shift <= 64)
                    {
                        while (charNum - shift <= 64)
                        {
                            shift = shift + 26;
                        }
                        array[i] = (char)(charNum - shift);
                    }
                    else if (charNum - shift >= 91)
                    {
                        while (charNum - shift >= 91)
                        {
                            shift = shift + 26;
                        }
                        array[i] = (char)(charNum - shift);
                    }
                }
                else if (charNum > 96 && charNum < 123)
                {
                    if (charNum - shift > 96 && charNum - shift < 123)
                    {
                        array[i] = (char)(charNum - shift);
                    }
                    else if (charNum - shift <= 96)
                    {
                        while (charNum - shift <= 96)
                        {
                            shift = shift + 26;
                        }
                        array[i] = (char)(charNum - shift);
                    }
                    else if (charNum - shift >= 123)
                    {
                        while (charNum - shift >= 123)
                        {
                            shift = shift + 26;
                        }
                        array[i] = (char)(charNum - shift);
                    }
                }
            }
            return new string(array);
        }
    }
}
