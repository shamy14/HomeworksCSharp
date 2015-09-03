using System;
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string comName = Console.ReadLine();
        Console.Write("Company address: ");
        string comAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string manFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string manLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int manAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        int manPhone = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine(comName);
        Console.WriteLine("Address: {0}", comAddress);
        Console.WriteLine("Tel.{0}", phoneNumber);
        if (string.IsNullOrEmpty(faxNumber))
        {
            Console.WriteLine("Fax: {0}", "(no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", faxNumber);
        }
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manFirstName, manLastName, manAge, manPhone);

    }
}
