using System;

class Program
{
    public static void Main()
    {
         int[] arr = { 1, 2, 3, 4, 5 };

        //[1] Using Two Pointers and while loop
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }

        Console.WriteLine(string.Join(" ", arr));

        //[2] using for loop

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }

        Console.WriteLine(string.Join(" ", arr));


        //builtin linq
        Array.Reverse(arr);

        Console.WriteLine(string.Join(" ", arr));

    }
}