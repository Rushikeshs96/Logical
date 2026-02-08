using System;

class Program
{
    public static void Main()
    {
        int number1 = 534;
        int number2 = 540;

        number1 = number1 + number2;
        number2 = number1 - number2;
        number1 = number1 - number2;

        System.Console.WriteLine($"Number1 : {number1} , number2 : {number2}");

    }
}