using System;

class Program
{
    static void Main()
    {
        int number = 10;
        string binary = "";

        while (number > 0)
        {
            binary = (number % 2) + binary;
            number /= 2;
        }

        Console.WriteLine(binary);
    }
}
