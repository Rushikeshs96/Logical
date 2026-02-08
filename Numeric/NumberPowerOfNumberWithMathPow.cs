using System;

class Program
{
    public static void Main()
    {
        int number = 4;
        int exponent = 2;
        int result = 1;

        for (int i = 1; i <= exponent; i++)
        {
            result = result * number;
        }
        System.Console.WriteLine(result);
    }
}