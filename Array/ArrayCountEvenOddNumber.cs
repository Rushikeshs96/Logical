using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("Even count = " + evenCount);
        Console.WriteLine("Odd count  = " + oddCount);



        //using linq
        //  int[] arr = { 1, 2, 3, 4, 5, 6 };

        // int evenCount = arr.Count(x => x % 2 == 0);
        // int oddCount  = arr.Count(x => x % 2 != 0);

        // Console.WriteLine($"Even = {evenCount}, Odd = {oddCount}");
    }
}
