using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 3, 3, 4 };

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }


        //using linq

        // int[] arr = { 1, 2, 2, 3, 3, 3, 4 };

        // var freq = arr.GroupBy(x => x);

        // foreach (var g in freq)
        // {
        //     Console.WriteLine($"{g.Key} -> {g.Count()}");
        // }

    }


}
