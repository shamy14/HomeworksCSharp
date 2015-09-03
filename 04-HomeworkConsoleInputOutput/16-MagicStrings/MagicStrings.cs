using System;

    class MagicStrings
    {
        static void Main()
        {
            int diff = int.Parse(Console.ReadLine());
            if(0<diff&&diff<17)
            {    for (int i = 1111; i <= 5555; i++)
                {
                    for (int j = 1111; j <= 5555; j++)
                    {
                        int num1 = j / 1000;
                        int num2 = j / 100 % 10;
                        int num3 = j / 10 % 10;
                        int num4 = j % 10;
                        int num5 = i / 1000;
                        int num6 = i / 100 % 10;
                        int num7 = i / 10 % 10;
                        int num8 = i % 10;
                        int sum1 = num1+num2+num3+num4;
                        int sum2=num5+num6+num7+num8;
                        if (diff==Math.Abs(sum1-sum2)
                            &&(num1==1||num1==3||num1==4||num1==5)
                            && (num2 == 1 || num2 == 3 || num2 == 4 || num2 == 5)
                             &&(num3 == 1 || num3 == 3 || num3 == 4 || num3 == 5)
                             &&(num4 == 1 || num4 == 3 || num4 == 4 || num4 == 5)
                            && (num5 == 1 || num5 == 3 || num5 == 4 || num5 == 5)
                            && (num6 == 1 || num6 == 3 || num6 == 4 || num6 == 5)
                             && (num7 == 1 || num7 == 3 || num7 == 4 || num7 == 5)
                             && (num8 == 1 || num8 == 3 || num8 == 4 || num8 == 5)
                            )
                        {
                            string str1 = j.ToString();
                            string str2 = i.ToString();
                            str1 = str1.Replace("1", "k").Replace("3", "s").Replace("4", "n").Replace("5", "p");
                            str2 = str2.Replace("1", "k").Replace("3", "s").Replace("4", "n").Replace("5", "p");
                            //Console.WriteLine(str1+str2);
                            Console.WriteLine(str2+str1);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

