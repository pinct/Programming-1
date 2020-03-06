using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            Random random = new Random();
            int randNum = random.Next(1, 4);
            char comp;
            Console.WriteLine("Enter r, p, or s");
            choice = Convert.ToChar(Console.ReadLine());
            if (randNum == 1)
            {
                comp = 'r';
            }
            else if (randNum == 2)
            {
                comp = 'p';
            }
            else
            {
                comp = 's';
            }
            if (comp == choice)
            {
                Console.WriteLine("Tie.");
            }
            else if ((choice == 1 && comp == 2) || (choice == 2 && comp == 3) || (choice == 3 && comp == 1))
            {
                Console.WriteLine("Computer wins.");
            }
            else
            {
                Console.WriteLine("You win.");
            }
        }
    }
}
