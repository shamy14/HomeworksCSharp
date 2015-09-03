using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Въведете числа за сумиране, разделени с интервал(space): ");
        double result = 0;
        string bigNumber = Console.ReadLine();
        string[] numbers = bigNumber.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < numbers.Length; i++)
        {
            result += double.Parse(numbers[i]);
        }
        Console.WriteLine(result);
    }
}
