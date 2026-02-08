using System;

class Program
{
    public static void Main()
    {
        int number = 57294;
        number = Math.Abs(number);

        int smallest = 9;
        int largest = 0;

        while (number > 0)
        {
            int digit = number % 10;

            if (digit < smallest)
                smallest = digit;

            if (digit > largest)
                largest = digit;

            number /= 10;
        }

        Console.WriteLine("Smallest digit = " + smallest);
        Console.WriteLine("Largest digit  = " + largest);
    }
}
