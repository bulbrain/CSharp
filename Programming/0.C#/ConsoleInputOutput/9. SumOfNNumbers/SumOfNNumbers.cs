// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
// Note that you may need to use a for-loop.
using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of numbers:");
        decimal n = decimal.Parse(Console.ReadLine());
        decimal sum = 0;
        decimal number = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number:");
            number = decimal.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is: " +sum);

    }
}