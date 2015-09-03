using System;

    class CatchTheBits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[n*8];
           
            for (int i = 0, count=1; i < n; i++, count++)
            {
                int number = int.Parse(Console.ReadLine());//get number from console make it binary
                for (int p = count * 8 - 1; p > (count - 1) * 8 - 1; p--)
                {
                    numbersArray[p] = number % 2;//add binry value
                    number /= 2;
                }
            }

            int[] afterStepArr = new int[n*8];
            for (int i = 1, j=0; i < n*8; i+=step, j++)
            {
                afterStepArr[j] = numbersArray[i];
            }

            
            while (afterStepArr.Length%8!=0)
            {
                afterStepArr[afterStepArr.Length] = 0;
            }


            int[] changedNumberDex = new int[n];
            int dexNumberInArray = 0, countPosition=1;
            while ( dexNumberInArray < n-1)
            {
                double sum = 0;
                double index = 0;
                for (int p = countPosition * 8 - 1; p > (countPosition - 1) * 8 - 1; p--)
                {
                    sum += afterStepArr[p] * (Math.Pow(2, index));
                    index++;
                }
                
                changedNumberDex[dexNumberInArray] = (int)sum;
                dexNumberInArray++; 
                countPosition++;

            }
            

            for (int i = 0; i < dexNumberInArray; i++)
            {
                Console.WriteLine(changedNumberDex[i]);
            }
        }
    }

