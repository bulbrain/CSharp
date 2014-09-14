// In combinatorics, the number of ways to choose k different members out of a group of n different elements 
// (also known as the number of combinations) is calculated by the following formula:

using System;

class CalculateFormula
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            int result1 = 1;
            int result2 = 1;
            int result;
            int count = 1;
            for (int index = n - k + 1; index <= n; index++)
            {
                result1 *= index;
                if (count <= k)
                {
                    result2 *= count;
                    count++;
                }
            }
            result = result1 / result2;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}