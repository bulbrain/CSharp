// You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product
// of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first 
// element is odd, the second is even, etc.
using System;

class oddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers separated by spaces:");
        string numbers = Console.ReadLine();
        string[] splitNumbers = numbers.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < splitNumbers.Length; i++)
        {
            int tempNumber = int.Parse(splitNumbers[i]);
            bool isOdd = (i + 1) % 2 != 0;
            bool isEven = (i + 1) % 2 == 0;

            if (isOdd)
            {
                oddProduct *= tempNumber;
            }
            if (isEven)
            {
                evenProduct *= tempNumber;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("The product is {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("Odd product is {0}", oddProduct);
            Console.WriteLine("Even product is {0}", evenProduct);
        }
    }
}