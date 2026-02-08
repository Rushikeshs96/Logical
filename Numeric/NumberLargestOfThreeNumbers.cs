using System;

class Program
{
    public static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;

        if (num1 >= num2 && num1 >= num3)
        {
            System.Console.WriteLine(num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            System.Console.WriteLine(num2);
        }
        else
        {
            System.Console.WriteLine(num3);
        }
    }
}