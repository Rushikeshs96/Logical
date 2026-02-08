using System;

class Program
{
    public static void Main()
    {
        for (int number = 1; number <= 1000; number++)
        {
            int temp = number;
            int digits = number.ToString().Length;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine(number);
            }
        }
    }
}
