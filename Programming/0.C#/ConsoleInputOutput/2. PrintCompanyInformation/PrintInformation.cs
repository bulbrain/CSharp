// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a 
// phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
using System;

class PrintInformation
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string name = Console.ReadLine();
        Console.WriteLine("Company address:");
        string address = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phone = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string fax = Console.ReadLine();
        Console.WriteLine("Website:");
        string web = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string manName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string manLastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        byte manAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone number:");
        string manPhone = Console.ReadLine();
        Console.WriteLine("-----------------------");
        Console.WriteLine("{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6}(age: {7}, tel. {8})", name, address, phone, fax, web, manName, manLastName, manAge, manPhone);
    }
}