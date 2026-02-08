using System;

class Program
{
    static void Main()
    {
        int n = 10;
        int count = 0;
        int number = 2;

        while (count < n)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
                count++;
            }
            number++;
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
