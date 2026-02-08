using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 10, 5, 20, 8 };

        if (arr.Length < 2)
        {
            Console.WriteLine("Second largest element not possible");
            return;
        }

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        if (secondLargest == int.MinValue)
            Console.WriteLine("Second largest element not found");
        else
            Console.WriteLine("Second largest = " + secondLargest);


        //using linq
           int secondLargest = arr
            .Distinct()
            .OrderByDescending(x => x)
            .Skip(1)
            .First();

        Console.WriteLine(secondLargest);
    }
}
