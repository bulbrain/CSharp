// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0. The result should be 0 or 1.
using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        int p = 3;
        uint nRightP = n >> p;
        uint bit = nRightP & 1;
        Console.WriteLine("Your bit is {0}", bit);
    }
}