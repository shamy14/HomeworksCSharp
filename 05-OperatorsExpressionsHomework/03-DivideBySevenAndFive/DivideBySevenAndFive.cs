using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Divided by 7 and 5? ");
        int n = int.Parse(Console.ReadLine());
        bool divider = (n % 7 == 0) && (n % 5 == 0);
        Console.WriteLine(divider);
    }
}
