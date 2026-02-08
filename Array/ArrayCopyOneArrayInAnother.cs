using System;

class Program
{
    public static void Main()
    {
        int[] source = { 1, 2, 3, 4, 5 };
        int[] target = new int[source.Length];

        // using for loop
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }

        Console.WriteLine(string.Join(" ", target));


        //using array.copy
        Array.Copy(source, target, source.Length);

        Console.WriteLine(string.Join(" ", target));


        //using foreach
        int index = 0;
        foreach (int item in source)
        {
            target[index++] = item;
        }

        Console.WriteLine(string.Join(" ", target));


        // using linq
        int[] source = { 1, 2, 3, 4, 5 };

        int[] target = source.ToArray();

        Console.WriteLine(string.Join(" ", target));
    }
}