using System;

class Program
{
    public static void Main()
    {
        string input = "He@llo! Wo#rld123";
        string result = "";    // can use stringbuilder also instead of result

        //[1] using isletter  or isletterOrDigit

        // foreach (char c in input)
        // {
        //     if (char.IsLetterOrDigit(c))
        //     {
        //         result = result + c;
        //     }
        // }
        // System.Console.WriteLine(result);


        //[2] using regex
       // string result = Regex.Replace(input, "[^a-zA-Z0-9]", "");
       // Console.WriteLine(result);
    }
}