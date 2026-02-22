using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 4, 20, 3, 10, 5 };
        int k = 33;

        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;

            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];

                if (sum == k)
                {
                    Console.WriteLine("Subarray found from index " + i + " to " + j);
                    found = true;
                    break;
                }
            }

            if (found)
                break;
        }

        if (!found)
            Console.WriteLine("No Subarray Found");
    }
}