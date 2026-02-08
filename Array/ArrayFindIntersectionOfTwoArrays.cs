using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 2, 3, 4 };
        int[] arr2 = { 2, 2, 4, 6 };

        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> result = new HashSet<int>();

        foreach (int num in arr2)
        {
            if (set1.Contains(num))
                result.Add(num);
        }

        Console.WriteLine(string.Join(" ", result));


        //using linq
        int[] intersection = arr1
           .Intersect(arr2)
           .ToArray();
        Console.WriteLine(string.Join(" ", intersection));

    }
}
