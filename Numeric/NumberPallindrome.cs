using System;

class Program
{
    public static void Main()
    {
        int number = 121;
        int original = number;
        int reverse = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number = number / 10;
        }

        if (original == reverse)
        {
            System.Console.WriteLine("pallindrome");
        }
        else
        {
            System.Console.WriteLine("Not a pallindrome");
        }
    }
}