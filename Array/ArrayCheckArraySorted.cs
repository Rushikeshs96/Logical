using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 5, 4, 3, 2, 1 };

        bool asc = true;
        bool desc = true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
                asc = false;

            if (arr[i] < arr[i + 1])
                desc = false;
        }

        if (asc || desc)
            Console.WriteLine("Sorted");
        else
            Console.WriteLine("Not Sorted");



        //using linq

        bool isSorted = arr.SequenceEqual(arr.OrderBy(x => x))
             || arr.SequenceEqual(arr.OrderByDescending(x => x));
        
        Console.WriteLine(isSorted ? "Sorted" : "Not Sorted");
    }
}