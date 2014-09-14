// Write a program that reads two positive integer numbers and prints how many numbers p exist between them
// such that the reminder of the division by 5 is 0.
using System;

class DevidibleNumbersInInterval
{
    static void Main()
    {
        Console.WriteLine("Start:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("End:");
        int end = int.Parse(Console.ReadLine());
        int mem = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            mem = mem + 1;
        }
        Console.WriteLine("Numbers divisible by 5 between your numbers: " + mem);
    }
}