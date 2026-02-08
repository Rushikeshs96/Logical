using System;

class Program
{
    public static void Main()
    {
        int number = 110;
        int sum = 0;

        while (number > 0)
        {
            sum = sum + number;
            sum = sum % 10;
            number = number / 10;
        }
        System.Console.WriteLine(sum);
    }
}