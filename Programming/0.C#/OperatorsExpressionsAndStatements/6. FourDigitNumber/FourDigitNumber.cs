// Write a program that takes a 4 digit number and calculates the sum of its digits, prints its digits in reverse order, prints
// its last digit in first position and exchanges its first and second digits. Must have 4 digits and cannot start with 0.
using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number(4 digits, cannot start with 0):");
        int n = int.Parse(Console.ReadLine());
        if (n < 1000 || n > 9999)
        {
            Console.WriteLine("Invalid number, must have 4 digits and cannot start with 0.");
        }
        else
        {
            int firstDigit = n % 10;
            int restNumberTwo = n / 10;
            int secondDigit = restNumberTwo % 10;
            int restNumberThree = n / 100;
            int thirdDigit = restNumberThree % 10;
            int restNumberFour = n / 1000;
            int fourthDigit = restNumberFour % 10;
            Console.WriteLine("Number: " + n);
            Console.WriteLine("Sum of digits: " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("Reversed: {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("Last digit in front: {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
    }
}