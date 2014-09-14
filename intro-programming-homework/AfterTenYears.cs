using System;

class AfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday:");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime currentDate = DateTime.Now;
        DateTime after10Years = currentDate.AddYears(10);
        int ageNow = currentDate.Year - birthDate.Year;
        int ageAfter = after10Years.Year - birthDate.Year;
        Console.WriteLine("You are {0} years old.", ageNow);
        Console.WriteLine("In ten years you are going to be {0} years old.", ageAfter);
    }
}