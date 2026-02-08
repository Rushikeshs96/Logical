using System;
class Program
{
    public static void Main()
    {
        //[1] find vowels aeio count using foreach loop
        string input = "Hello World";
        int count = 0;

        // foreach (var i in input.ToLower())
        // {
        //     if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
        //     {
        //         count++;
        //     }
        // }
        // System.Console.WriteLine(count);

        //[2] using for loop

        // for(int i=0;i<input.Length; i++)
        // {
        //     char c = char.ToLower(input[i]);
        //     if ("aeiou".Contains(c))
        //     {
        //         count++;
        //     }
        // }
        // Console.WriteLine(count);

        // [3] using linq 
        count = input.Count(c => "aeioAEIOU".Contains(c));
        System.Console.WriteLine(count);
    }
}