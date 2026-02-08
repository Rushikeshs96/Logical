using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach (int num in arr)
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }

        Console.WriteLine("Even: " + string.Join(" ", even));
        Console.WriteLine("Odd : " + string.Join(" ", odd));



        //using linq
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        var even = arr.Where(x => x % 2 == 0);
        var odd  = arr.Where(x => x % 2 != 0);

        Console.WriteLine("Even: " + string.Join(" ", even));
        Console.WriteLine("Odd : " + string.Join(" ", odd));

    }



}
