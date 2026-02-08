using System;

class Program
{
    public static void Main()
    {
        // Examples
        // 19 → 1+9 = 10 → 1+0 = 1 ✅ (Magic)
        // 123 → 1+2+3 = 6 ❌ (Not Magic)
        // 10 → 1+0 = 1 ✅ (Magic)

        int number = 19;

        while (number > 9)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            number = sum;
        }

        if (number == 1)
            Console.WriteLine("Magic Number");
        else
            Console.WriteLine("Not a Magic Number");
    }
}