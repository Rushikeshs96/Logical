using System;

class Program
{
    public static void Main()
    {
        int number = 12345;
        int count = 0;
        while (number > 0)
        {
            count++;
            number = number / 10;
        }
        System.Console.WriteLine(count);
    }
}