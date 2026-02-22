using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

        //using hashset
        HashSet<int> unique = new HashSet<int>(arr);

        // int[] result = new int[unique.Count];
        // unique.CopyTo(result);

        // Console.WriteLine(string.Join(" ", result));



        //using preserving order

        // List<int> result = new List<int>();

        // foreach (int num in arr)
        // {
        //     if (!result.Contains(num))
        //     {
        //         result.Add(num);
        //     }
        // }
        // Console.WriteLine(string.Join(" ", result));


        List<int> digits = new List<int>();

        for(int i = 0; i < arr.Length; i++)
        {
            if (!digits.Contains(arr[i]))
            {
                digits.Add(arr[i]);
            }
        }
        Console.WriteLine(string.Join(" ", digits));

        //using linq

        // int[] result = arr.Distinct().ToArray();

        // Console.WriteLine(string.Join(" ", result));
    }
}
