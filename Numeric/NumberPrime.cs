using System;

class Program
{
    public static void Main()
    {
        int number = 17;
        bool isPrime = true;

        if (number <= 1)
        {
            Console.WriteLine("Not Prime");
            return;
        }

        for (int i = 2; i < number; i++)            // use (int i = 2; i * i <= num; i++)  this loop in interview
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? "Prime" : "Not Prime");
    }
}
