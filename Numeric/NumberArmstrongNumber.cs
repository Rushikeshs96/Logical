using System;

class Program
{
    public static void Main()
    {
        //examples
        //153 → 1³ + 5³ + 3³ = 153 ✅
        //370 → 3³ + 7³ + 0³ = 370 ✅           //here is 3 is count of number / power
        //1634 → 1⁴ + 6⁴ + 3⁴ + 4⁴ = 1634 ✅    // here is 4 is count of number / power
        int number = 153;
        int temp = number;
        int countOfNumber = 0;
        int sum = 0;

        while (temp > 0)
        {
            countOfNumber++;
            temp = temp / 10;
        }
        temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum = sum + (int)Math.Pow(digit, countOfNumber);                  // count of number is power;
            temp = temp / 10;
        }
        System.Console.WriteLine(sum == number? "Armstrong":"not armstrong");
    }
}