// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer.");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Your integer in binary: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        uint firstBits = (n >> 3) & 7;
        uint secondBits = (n >> 24) & 7;
        uint maskFirstBits = 7 << 3;
        uint maskSecondBits = 7 << 24;
        n = n & ~maskFirstBits | (secondBits << 3);
        n = n & ~maskSecondBits | (firstBits << 24);
        Console.WriteLine("Result: {0}", n);
        Console.WriteLine("Binary result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}