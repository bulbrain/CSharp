// We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n
// to hold the value v at the position p from the binary representation of n while preserving all other bits of n.
using System;

class ModifyABit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value(0 or 1):");
        int v = int.Parse(Console.ReadLine());
        if (v < 0 || v > 1)
        {
            Console.WriteLine("Invalid value, only 0 or 1.");
        }
        else
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The result is: {0}", result);
            Console.WriteLine("The result in binary: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("The result is: {0}", result);
            Console.WriteLine("The result in binary: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        }

    }
}