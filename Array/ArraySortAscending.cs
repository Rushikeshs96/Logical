using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 3 };

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine(string.Join(" ", arr));



        //using linq
         int[] arr = { 5, 2, 9, 1, 3 };

        int[] sorted = arr.OrderBy(x => x).ToArray();

        Console.WriteLine(string.Join(" ", sorted));
    }
}
