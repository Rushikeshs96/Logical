using System;

class Program
{
    public static void Main()
    {
         int number = 12345;
        int reverse = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number = number / 10;
        }
        System.Console.WriteLine(reverse);
    }
}