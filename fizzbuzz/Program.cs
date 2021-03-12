using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i);
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(" - ");
                    if (i % 3 == 0) Console.Write("Fizz");
                    if (i % 5 == 0) Console.Write("Buzz");
                }
                Console.WriteLine();
            }
        }
    }
}
