using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 3, 6 };

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        Console.WriteLine("Duplicate elements:");
        foreach (var item in freq)
        {
            if (item.Value > 1)
                Console.Write(item.Key + " ");
        }


        //using linq
        int[] arr = { 1, 2, 3, 2, 4, 5, 3, 6 };

        var duplicates = arr.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key);

        Console.WriteLine(string.Join(" ", duplicates));

    }
}
