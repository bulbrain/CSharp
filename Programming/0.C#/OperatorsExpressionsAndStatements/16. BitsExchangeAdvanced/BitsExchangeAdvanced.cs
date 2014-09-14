// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
// The first and the second sequence of bits may not overlap.
using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Your integer in binary: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter the first bits position P:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second bits position Q:");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length K:");
        int k = int.Parse(Console.ReadLine());
        int firstBits = (n >> p) & 7;
        int secondBits = (n >> q) & 7;
        int maskFirstBits = 7 << p;
        int maskSecondBits = 7 << q;
        n = n & ~maskFirstBits | (secondBits << p);
        n = n & ~maskSecondBits | (firstBits << q);
        Console.WriteLine("Result: {0}", n);
        Console.WriteLine("Binary result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}