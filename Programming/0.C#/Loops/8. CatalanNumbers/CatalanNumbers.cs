// Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
using System;
using System.numerics

class catalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        long n = long.Parse(Console.ReadLine());
        if (n >= 0 && n <100)
        {
            long numerator = 1;
            long denominator = 1;
            long result = 1;
            for (int k = 2; k <= n; k++)
            {
                numerator *= n + k;
                denominator *= k;
            }
            result = numerator / denominator;
            Console.WriteLine(result);
        }
    }
}