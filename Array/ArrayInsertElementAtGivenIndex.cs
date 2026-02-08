using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 10, 20, 30, 40 };
        int element = 25;
        int index = 2;

        if (index < 0 || index > arr.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        int[] result = new int[arr.Length + 1];

        // 1️⃣ Copy elements before index
        for (int i = 0; i < index; i++)
        {
            result[i] = arr[i];
        }

        // 2️⃣ Insert new element
        result[index] = element;

        // 3️⃣ Copy remaining elements
        for (int i = index; i < arr.Length; i++)
        {
            result[i + 1] = arr[i];
        }

        Console.WriteLine(string.Join(" ", result));


    }
}
