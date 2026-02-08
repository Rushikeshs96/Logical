using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 4, 7, 1, 9, 3 };

        if (arr.Length == 0)
        {
            Console.WriteLine("Array is empty");
            return;
        }

        int min = arr[0];
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];

            if (arr[i] > max)
                max = arr[i];
        }

        Console.WriteLine($"Min = {min}, Max = {max}");
    }
}
