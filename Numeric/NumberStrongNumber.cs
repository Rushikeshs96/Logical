using System;

class Program
{
    public static void Main()
    {
        // Examples
        // 145 → 1! + 4! + 5! = 1 + 24 + 120 = 145 ✅
        // 2 → 2! = 2 ✅
        // 123 → 1! + 2! + 3! = 9 ❌

        int number = 145;
        int original = number;
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum = sum + Fact(digit);
            number = number / 10;
        }
        System.Console.WriteLine(original == sum ? "Strong Number":"Not a Strong Number");
    }

    public static int Fact(int number)
    {
        int fact = 1;
        for(int i =1; i<=number; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
}