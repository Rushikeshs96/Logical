using System;

class Program
{
    public static void Main()
    {
         string input = "123456l";
        bool isOnlyDigits = true;

        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                isOnlyDigits = false;
                break;
            }
        }

        Console.WriteLine(isOnlyDigits);
    }
}