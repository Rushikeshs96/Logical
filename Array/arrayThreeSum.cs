using System;

class Program
{
    public static void Main()
    {
        int[] arr = {2, 7, 11, 15, -2, 9, 5};
        int target = 9;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[i] + arr[j] + arr[k] == target)
                    {
                        Console.WriteLine(
                           $"Values: {arr[i]} + {arr[j]} + {arr[k]} at index: {i}, {j}, {k}");
                    }

                }
            }
        }
    }
}