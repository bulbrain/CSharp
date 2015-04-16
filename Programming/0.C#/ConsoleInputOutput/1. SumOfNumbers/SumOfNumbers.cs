// Write a program that reads 3 real numbers from the console and prints their sum.
using System;

class SumOfNumbers
{
    static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Insert a number:");
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
