// Write an expression that extracts from given integer n the value of given bit at index p
using System;

class BitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter the bit position:");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine("Your bit is {0}", bit);
    }
}