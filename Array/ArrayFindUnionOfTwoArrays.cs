using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 2, 3, 4 };
        int[] arr2 = { 2, 4, 5, 6 };

        HashSet<int> union = new HashSet<int>();

        foreach (int num in arr1)
            union.Add(num);

        foreach (int num in arr2)
            union.Add(num);

        Console.WriteLine(string.Join(" ", union));



        //using linq
        int[] intersection = arr1
           .Union(arr2)
           .ToArray();
            
                Console.WriteLine(string.Join(" ", intersection));

    }
}
