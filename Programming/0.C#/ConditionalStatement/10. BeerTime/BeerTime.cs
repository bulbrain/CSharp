using System;

class BeerTime
{
    static void Main()
    {
        string time = Console.ReadLine();
        DateTime dt =
        DateTime.ParseExact(time, "yyyy-MM-dd HH:mm");
    }
}