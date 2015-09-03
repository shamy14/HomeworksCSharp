using System;
class SumOfnNumbers
{
    static void Main()
    {
        double sum = 0;
        double n = double.Parse(Console.ReadLine());
        double number = double.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}
