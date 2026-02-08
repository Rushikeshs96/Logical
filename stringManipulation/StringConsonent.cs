using System;

class Program
{
    public static void Main()
    {
        string input = "Interview Question";
        int count = 0;

        //[1] using for loop    
        // for (int i = 0; i < input.Length; i++)
        // {
        //     char c = char.ToLower(input[i]);
        //     if (char.IsLetter(c) && !"aeiou".Contains(c))
        //     {
        //         count++;
        //     }
        // }   
        // System.Console.WriteLine(count);

        //[2] using foreach loop
        // foreach (var c in input.ToLower())
        // {
        //     if (char.IsLetter(c) && !"aeiou".Contains(c))
        //     {
        //         count++;
        //     }
        // }
        // System.Console.WriteLine(count);

        //  [3] using linq
        count = input.ToLower().Count(c => char.IsLetter(c) && !"aeiou".Contains(c));
        System.Console.WriteLine(count);
    }
}