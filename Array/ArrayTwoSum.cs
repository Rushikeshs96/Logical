using System;

class Program
{
    public static void Main()
    {
        int[] arr = {2, 7, 11, 15, -2, 9, 5};
        int target = 9;

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i+1; j < arr.Length; j++)
            {
                if(arr[i]+arr[j] == target)
                {
                    System.Console.WriteLine($"values are :{arr[i]} + {arr[j]} at index: {i} + {j}");
                }
            }
        }
    }
}