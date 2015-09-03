using System;

class MyAgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday(try yyyy.m.d)");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        DateTime Today = DateTime.Now;
        int age = Today.Year - BirthDay.Year;
        if ((BirthDay.Month <= Today.Month && BirthDay.Day <= Today.Day) ^ (BirthDay.Month < Today.Month && BirthDay.Day > Today.Day))
        {
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("After 10 years you will be {0} years old", age + 10);
            Console.WriteLine("Year after 10 years will be : " + (Today.Year + 10));
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You are {0} years old.", age - 1);
            Console.WriteLine("After 10 years you will be {0} years old", age + 9);
            Console.WriteLine("Year after 10 years will be : " + (Today.Year + 10));
            Console.ReadLine();
        }
    }
}
