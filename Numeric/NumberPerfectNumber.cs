using System;

class Program
{
    public static void Main()
    {
        // Sum of its proper divisors (excluding the number itself) = the number

        // Examples

        // 6 → 1 + 2 + 3 = 6 ✅

        // 28 → 1 + 2 + 4 + 7 + 14 = 28 ✅

        // 12 → 1 + 2 + 3 + 4 + 6 = 16 ❌


        int number = 28;
        int sum = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum = sum + i;
            }
        }
        System.Console.WriteLine(number == sum ? "perfect": "not perfect");
    }
}