using System;

class Program
{
    static void Main()
    {
        // int[] arr = { 1, 2, 3, 4, 5 };
        // int k = 2;
        // int n = arr.Length;

        // k = k % n;
        // int[] result = new int[n];

        // for (int i = 0; i < n; i++)
        // {
        //     result[(i + k) % n] = arr[i];
        // }

        // Console.WriteLine(string.Join(" ", result));



        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;
        int n = arr.Length;

        k = k % n;

        Reverse(arr, 0, n - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);

        Console.WriteLine(string.Join(" ", arr));

    }

     static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}
