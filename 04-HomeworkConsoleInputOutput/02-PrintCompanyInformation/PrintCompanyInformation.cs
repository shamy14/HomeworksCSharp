using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("{0,-20}", "Company name:");
            string companyName = Console.ReadLine();
            Console.Write("{0,-20}", "Company adress:");
            string companyAdress = Console.ReadLine();
            Console.Write("{0,-20}", "Phone number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("{0,-20}", "Fax Number:");
            string faxNumber = Console.ReadLine();
            if (faxNumber=="")
            {
                faxNumber = "(no fax)";
            }
            Console.Write("{0,-20}", "Web site:");
            string webSite = Console.ReadLine();
            Console.Write("{0,-20}", "Manager first name:");
            string manFirstName = Console.ReadLine();
            Console.Write("{0,-20}", "Manager last name:");
            string manLastName = Console.ReadLine();
            Console.Write("{0,-20}", "Manager age:");
            string managerAge = Console.ReadLine();
            Console.Write("{0,-20}", "Manager phone:");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel: {8})\n",
                companyName, companyAdress, phoneNumber,faxNumber, webSite,manFirstName,manLastName,managerAge,managerPhone);


        }
    }

