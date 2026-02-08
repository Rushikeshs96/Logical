using System;

class Program
{
    public static void Main()
    {
        string input = "swiss";

        // [1] using linq
        // string result = new string(input.Distinct().ToArray());
        // Console.WriteLine(result);

      //  [2] HashSet is used because it stores only unique elements and provides constant-time lookup, making duplicate removal efficient.
        // also when added duplicates it return false
        HashSet<char> seen = new HashSet<char>();
        string result = "";
        foreach(var c in input)
        {
            if (seen.Add(c))            // Add returns false if already exists
            {
                result += c;
            }
        }
        System.Console.WriteLine(result);
    }
}