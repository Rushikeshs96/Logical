using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        System.Console.WriteLine(min);


        //linq
         int largest = arr.Min();

        Console.WriteLine(largest);

    }
}