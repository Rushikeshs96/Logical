using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, -2, 4 };

        int maxProduct = arr[0];
        int minProduct = arr[0];
        int result = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            // If current number is negative, swap
            if (arr[i] < 0)
            {
                int temp = maxProduct;
                maxProduct = minProduct;
                minProduct = temp;
            }

            // Update max and min
            maxProduct = Math.Max(arr[i], maxProduct * arr[i]);
            minProduct = Math.Min(arr[i], minProduct * arr[i]);

            // Update result
            if (maxProduct > result)
            {
                result = maxProduct;
            }
        }

        Console.WriteLine("Maximum Product: " + result);
    }
}