using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            DisplayMenu();
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 0)
            {
                if (choice == 1)
                {
                    Console.WriteLine($"Sum: {CalculateSum(5)}");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("How many integers are you inputting?");
                    Console.WriteLine($"Sum: {CalculateSumOfSquares(Convert.ToInt32(Console.ReadLine()))}");
                }
                else if (choice == 3)
                {
                    Console.WriteLine($"Sum: {CalculateSumOfCubes()}");
                }
                else if (choice == 4)
                {
                    Console.WriteLine($"Average: {CalculateAverage()}");
                }
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("4) Calculate Average");
            Console.WriteLine("0) Exit");
            Console.WriteLine("");
            Console.WriteLine("Enter the number that corresponds to your choice:");
        }
        static int CalculateSum(int integers)
        {
            int sum = 0;
            for (int i = 0; i < integers; i++)
            {
                Console.WriteLine("Enter an integer");
                sum = Convert.ToInt32(Console.ReadLine()) + sum;
            }
            return sum;
        }
        static int CalculateSumOfSquares(int integers)
        {
            int sum = 0;
            for (int i = 0; i < integers; i++)
            {
                Console.WriteLine("Enter an integer");
                int input = Convert.ToInt32(Console.ReadLine());
                sum = input * input + sum;
            }
            return sum;
        }
        static int CalculateSumOfCubes()
        {
            int sum = 0;
            Console.WriteLine("How many integers are you inputting?");
            int integers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < integers; i++)
            {
                Console.WriteLine("Enter an integer");
                int input = Convert.ToInt32(Console.ReadLine());
                sum = input * input * input + sum;
            }
            return sum;
        }
        static double CalculateAverage()
        {
            double sum = 0;
            Console.WriteLine("How many integers are you inputting?");
            int integers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < integers; i++)
            {
                Console.WriteLine("Enter an integer");
                int input = Convert.ToInt32(Console.ReadLine());
                sum = input + sum;
            }
            return (sum / integers);
        }
    }
}
