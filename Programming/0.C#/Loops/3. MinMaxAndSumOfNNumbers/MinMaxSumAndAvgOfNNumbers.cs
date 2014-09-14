// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
// the sum and the average of all numbers (displayed with 2 digits after the decimal point). 

using System;
using System.Collections.Generic;

class minMaxSumAndAvgOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of lines:");
        string inputStr = Console.ReadLine();
        int countN = int.Parse(inputStr);
        List<int> numbers = new List<int>(countN);
        for (int i = 0; i < countN; i++)
        {
            Console.Write("Enter the next whole number of sequence: ");
            inputStr = Console.ReadLine();
            numbers.Add(int.Parse(inputStr));
        }
        int numMin = int.MaxValue;
        int numMax = int.MinValue;
        int sumOfAllNumbers = 0;
        foreach (var number in numbers)
        {
            numMin = Math.Min(numMin, number);
            numMax = Math.Max(numMax, number);
            sumOfAllNumbers += number;
        }
        double averageNumbers = sumOfAllNumbers / 2.0;
        Console.WriteLine("min = " + numMin);
        Console.WriteLine("max = " + numMax);
        Console.WriteLine("sum = " + sumOfAllNumbers);
        Console.WriteLine("avg = {0:0.00}", averageNumbers);
    }
}