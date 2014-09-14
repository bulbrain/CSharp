// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
// like in the examples below. Use two nested loops.
using System;

class matrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer.");
        int n = int.Parse(Console.ReadLine());
        if (n >= 1 && n <= 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int e = 1 + i; e <= n + i; e++)
                {
                    Console.Write(e);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid integer, must be more than 0 and less than 21.");
        }
    }
}