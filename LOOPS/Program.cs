using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 2: Loops
        Console.WriteLine("\nUsing for loop to display first 10 natural numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nUsing while loop to display first 10 natural numbers:");
            int j = 1;
            while (j <= 10)
            {
                Console.Write($"{j} ");
                j++;
            }

            Console.WriteLine("\nUsing do-while loop to display first 10 odd natural numbers:");
            int k = 1;
            do
            {
                if (k % 2 != 0)
                    Console.Write($"{k} ");
                k++;
            } while (k <= 10);
            Console.ReadKey();
        }
    }
}
