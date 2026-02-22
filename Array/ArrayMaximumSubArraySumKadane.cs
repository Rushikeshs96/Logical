using System;

class Program
{
    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSum = arr[0];
        int currentSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentSum = currentSum + arr[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            // If current sum becomes negative, reset it
            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }

        Console.WriteLine("Maximum Subarray Sum: " + maxSum);
    }
}