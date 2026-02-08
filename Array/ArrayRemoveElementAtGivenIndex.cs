using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int index = 2;

        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        for (int i = index; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        // print array (size reduced by 1)
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + " ");
        }



        //using linq
        int[] result = arr
            .Where((value, i) => i != index)
            .ToArray();

        Console.WriteLine(string.Join(" ", result));
    }
}
