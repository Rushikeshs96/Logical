using System;

class Program
{
    public static void Main()
    {
        int number = 57294;
        number = Math.Abs(number);

        int largest = -1;
        int secondLargest = -1;

        while (number > 0)
        {
            int digit = number % 10;

            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }

            number /= 10;
        }

        if (secondLargest == -1)
            Console.WriteLine("Second largest digit not found");
        else
            Console.WriteLine("Second largest digit = " + secondLargest);
    }
}
