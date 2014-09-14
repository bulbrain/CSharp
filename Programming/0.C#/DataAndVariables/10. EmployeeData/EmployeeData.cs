using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Georgi";
        string lastName = "Ganev";
        byte age = 23;
        char gen = 'M';
        ulong personalID = 8306112507L;
        uint employeeID = 27569999;
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gen);
        Console.WriteLine("Personal ID number: {0}", personalID);
        Console.WriteLine("Unique employee number: {0}", employeeID);
    }
}