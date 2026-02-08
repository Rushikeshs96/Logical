using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 4, 2, 1, 3, 5 };

        if (arr.Length < 2)
        {
            Console.WriteLine("Not enough elements");
            return;
        }

        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int num in arr)
        {
            if (num < smallest)
            {
                secondSmallest = smallest;
                smallest = num;
            }
            else if (num < secondSmallest && num != smallest)
            {
                secondSmallest = num;
            }
        }

        if (secondSmallest == int.MaxValue)
            Console.WriteLine("Second smallest element not found");
        else
            Console.WriteLine($"Smallest = {smallest}, Second Smallest = {secondSmallest}");




        //using linq
        int[] arr = { 4, 2, 1, 3, 5 };

        var result = arr.Distinct().OrderBy(x => x).ToArray();

        if (result.Length < 2)
            Console.WriteLine("Not enough unique elements");
        else
            Console.WriteLine($"Smallest = {result[0]}, Second Smallest = {result[1]}");

    }
}
