using System;

class Program
{
    public static void Main()
    {
        int start = 10;
        int end = 30;

        for(int i =start; i<= end; i++)
        {
            bool isPrime = true;

            if (i <= 1)
            {
                continue;
            }
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                System.Console.WriteLine("Prime : "+i);
            }
        }
    }
}