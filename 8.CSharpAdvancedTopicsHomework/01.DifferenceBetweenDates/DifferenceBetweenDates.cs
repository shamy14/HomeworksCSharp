using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two dates:");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan ts = secondDate - firstDate;
        int differenceDays = ts.Days;
        Console.WriteLine(differenceDays);
    }
}