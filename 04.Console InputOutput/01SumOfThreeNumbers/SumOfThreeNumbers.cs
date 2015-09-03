using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Въведете стйност за a: ");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Въведете стйност за b: ");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Въведете стйност за c: ");
        double c = Double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("Сумата на въведенети числа е: {0}",sum);
    }
}
