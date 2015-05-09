using System;

// Problem 2.Print Company Information
// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and its manager and prints it back on the console.


class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter company name: ");
        string sCompanyName = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string sCompanyAddress = Console.ReadLine();
        Console.WriteLine("Enter company phone number: ");
        string sCompanyPhoneNumber = Console.ReadLine();
        Console.WriteLine("Enter company fax number: ");
        string sCompanyFaxNumber = Console.ReadLine();
        Console.WriteLine("Enter company web site: ");
        string sCompanyWebSite = Console.ReadLine();
        Console.WriteLine("Enter company manager first name: ");
        string sFirstName = Console.ReadLine();
        Console.WriteLine("Enter company manager last name: ");
        string sLastName = Console.ReadLine();
        Console.WriteLine("Enter company manager age: ");
        string sAge = Console.ReadLine();
        Console.WriteLine("Enter company manager phone number: ");
        string sManagerPhoneNumber = Console.ReadLine();


        Console.WriteLine(sCompanyName);
        Console.WriteLine("Address: {0}", sCompanyAddress);
        Console.WriteLine("Phone: {0}", (sCompanyPhoneNumber == String.Empty) ? "No phone" : sCompanyPhoneNumber);
        Console.WriteLine("Fax: {0}", (sCompanyFaxNumber == String.Empty) ? "No fax" : sCompanyFaxNumber);
        Console.WriteLine("Web site: {0}", sCompanyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, phone: {3})", sFirstName, sLastName, sAge, sManagerPhoneNumber);

    }
}

