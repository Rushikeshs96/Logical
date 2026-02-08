using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        HashSet<int> seen = new HashSet<int>();

        foreach (int num in arr)
        {
            int complement = target - num;

            if (seen.Contains(complement))
            {
                Console.WriteLine($"Pair found: {complement}, {num}");
                return;
            }

            seen.Add(num);
        }

        Console.WriteLine("No pair found");
        
    }
}
