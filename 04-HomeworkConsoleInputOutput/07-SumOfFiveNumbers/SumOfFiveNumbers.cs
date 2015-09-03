using System;

    class SumOfFiveNumbers
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] cutNumbers = numbers.Split(' ');
            double sum = 0;
            foreach (string newNum in cutNumbers)
            {
                sum += double.Parse(newNum);
            }
            Console.WriteLine("Sum: "+sum);
        }
    }

