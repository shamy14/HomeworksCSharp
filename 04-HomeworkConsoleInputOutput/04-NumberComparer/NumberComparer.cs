using System;

    class NumberComparer
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            switch (firstNumber.CompareTo(secondNumber))
            {
                case 1:
                    Console.WriteLine(firstNumber);
                break;
                case -1:
                    Console.WriteLine(secondNumber);
                break;
                default:
                    Console.WriteLine(firstNumber);
                break;
            }
        }
    }

