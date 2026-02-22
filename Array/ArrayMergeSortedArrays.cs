using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 3, 5 };
        int[] arr2 = { 2, 4, 6 };

        int[] result = new int[arr1.Length + arr2.Length];

        int i = 0, j = 0;

        for (int k = 0; k < result.Length; k++)
        {
            if (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                }
                else
                {
                    result[k] = arr2[j];
                    j++;
                }
            }
            else if (i < arr1.Length)
            {
                result[k] = arr1[i];
                i++;
            }
            else
            {
                result[k] = arr2[j];
                j++;
            }
        }

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}