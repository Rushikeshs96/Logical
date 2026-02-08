using System;

class Program
{
    public static void Main()
    {
         int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
        }
        System.Console.WriteLine(sum);


        //linq
        int sum = arr.Sum();
        System.Console.WriteLine(sum);

    }
}