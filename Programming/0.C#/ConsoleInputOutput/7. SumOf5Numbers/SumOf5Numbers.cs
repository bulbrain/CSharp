// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers.");
        string n = Console.ReadLine();
        decimal sum = 0;
        string[] nAsStrings = n.Split(' ');
        for (int i = 0; i < nAsStrings.Length; i++)
        {
            sum += decimal.Parse(nAsStrings[i]);
        }
        Console.WriteLine("The sum of the numbers is: " +sum);
    }
}