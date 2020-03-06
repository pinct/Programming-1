using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        //Michael Courneya - 301106259
        static void Main(string[] args)
        {
            char answer;
            int texts;
            double discount = 1;
            Console.WriteLine("Hardcover? (Y/N)");
            answer = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine("Enter number of Textbooks.");
            texts = Convert.ToInt32(Console.ReadLine());
            switch (texts > 4)
            {
                case true:
                    discount = .95;
                    break;
                case false:
                    break;
            }
            switch (answer)
            {
                case 'y':
                    Console.WriteLine($"Total = {texts * 125 * discount + (texts * 125 * .2)}");
                    break;
                case 'n':
                    Console.WriteLine($"Total = {texts * 125 * discount}");
                    break;
                default:
                    Console.WriteLine("Invalid Hardcover Answer.");
                    break;
            }
        }
    }
}
