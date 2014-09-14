// Write a program that enters from the console a positive integer N and print all the integers from 1 to N, 
// on a singe line, separated by spaces.
using System;

class numbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer.");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}