// Write a program that reads a n number and prints the first n numbers of the Fibonacci sequence (at a single line, separated
// by spaces). Note that you may need to learn how to use loops.
using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of fibonacci numbers.");
        int n = int.Parse(Console.ReadLine());
        int firstnum = 0;
        int nextnum = 1;
        int mem;
        Console.Write(firstnum + " ");
        Console.Write(nextnum + " ");
        for (int i = 2; i < n; i++)
        {
            mem = firstnum + nextnum;
            Console.Write(mem + " ");
            firstnum = nextnum;
            nextnum = mem;
        }
    }
}