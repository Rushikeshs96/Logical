using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 0, 1, 0, 3, 12 };

        int count = 0; // position to place next non-zero element

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[count] = arr[i];
                count++;
            }
        }

        while (count < arr.Length)
        {
            arr[count] = 0;
            count++;
        }
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}