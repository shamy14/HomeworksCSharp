using System;
class NineDigitMagicNumbers
{
    private static bool isPossible(int a)
    {
        if (a / 100 > 7 || a / 100 < 1 || a / 10 % 10 > 7 || a / 10 % 10 < 1 || a % 10 > 7 || a % 10 < 1)
        {
            return false;
        }
        return true;
    }
    private static int sumOfDigits(int a)
    {
        return ((a / 100) + ((a / 10) % 10) + (a % 10)); 
        
    }
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 111; i <= 777; i++)
        {
            int number2 = i + diff;
            int number3 = number2 + diff;
            if ((number3 <= 777) && isPossible(i) && isPossible(number2) && isPossible(number3) && (sumOfDigits(i) + sumOfDigits(number2) + sumOfDigits(number3) == sum)) 
            {
                Console.WriteLine("{0}{1}{2}", i, number2, number3);
                counter++;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}
