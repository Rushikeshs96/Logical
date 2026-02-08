using System;

class Program
{
    static void Main()
    {
        int binary = 1010;
        int decimalValue = 0;
        int baseValue = 1;

        while (binary > 0)
        {
            int lastDigit = binary % 10;
            decimalValue += lastDigit * baseValue;
            baseValue *= 2;
            binary /= 10;
        }

        Console.WriteLine(decimalValue);
    }
}
