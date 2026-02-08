using System;

class Program
{
    public static void Main()
    {
        int a = 36;
        int b = 24;

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine(a);
    }
}