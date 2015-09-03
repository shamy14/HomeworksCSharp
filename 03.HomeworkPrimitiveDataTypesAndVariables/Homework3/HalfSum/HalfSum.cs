using System;
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int size=2*n;
        int[] array = new int[size];
        long sum1 = 0, sum2 = 0;
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            if (i < size / 2)
            {
                sum1 += array[i];
            }
            else
            {
                sum2 += array[i];
            }
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            long answer=Math.Abs(sum1-sum2);
            Console.WriteLine("No, diff={0}", answer);
        }
    }
}
