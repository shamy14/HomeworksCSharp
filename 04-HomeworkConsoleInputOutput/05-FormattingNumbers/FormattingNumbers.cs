using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = 0;
        double b = 0, c = 0;
        a = int.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:0.00}|{3,-10:0.000}|",
            a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);

    }
}

