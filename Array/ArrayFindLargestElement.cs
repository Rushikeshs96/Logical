using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 3, 7, 2, 9, 5 };

        int max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        System.Console.WriteLine(max);


        //linq
         int largest = arr.Max();

        Console.WriteLine(largest);
    }
}