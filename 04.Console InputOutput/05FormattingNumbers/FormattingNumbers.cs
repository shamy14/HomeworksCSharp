using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Въведете стойност за A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Въведете стойност за B: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Въведете стойност за C: ");
        float c = float.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid number \"A\"!");
        }
        else
        {
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
