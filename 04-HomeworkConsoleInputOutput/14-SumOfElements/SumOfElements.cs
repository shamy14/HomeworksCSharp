using System;

    class SumOfElements
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] cutNumbers = numbers.Split(' ');
            int sum = 0;
            int biggestElement = 0;
            foreach (string newNum in cutNumbers)
            {
                sum += int.Parse(newNum);
                if (biggestElement<int.Parse(newNum))
                {
                    biggestElement = int.Parse(newNum);
                }
            }
            int diff = Math.Abs(sum - 2 * biggestElement);
            if (diff==0)
            {
                Console.WriteLine("Yes, sum="+biggestElement);
            }
            else
            {
                Console.WriteLine("No, diff="+diff);
            }
        }
    }
