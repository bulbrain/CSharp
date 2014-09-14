// Write a Boolean expression that returns if the bit at position p in given integer number n has value of 1. 
using System;
class CheckABit
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
        bool check;
        if (bit == 1)
        {
            check = true;
        }
        else
        {
            check = false;
        }
        Console.WriteLine("Bit is 1? {0}", check);
    }
}