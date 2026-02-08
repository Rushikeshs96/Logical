using System;

class Program
{
    public static void Main()
    {
        int number = 5123;
        int even = 0;
        int odd = 0;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
            number = number / 10;
        }
        System.Console.WriteLine($"even : {even}, odd : {odd}");
    }
}