using System;

class Program
{
    public static void Main()
    {
        string sentence = "Find the longest word in a sentence";

        //[1] using split and forloop

        // string[] arr = sentence.Split(' ');
        // string longestWord = "";

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if(arr[i].Length > longestWord.Length)
        //     {
        //         longestWord = arr[i];
        //     }
        // }
        // System.Console.WriteLine(longestWord);

        //[2] using foreach loop
        string[] words = sentence.Split(' ');
        string longest = words[0];

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        Console.WriteLine(longest);
    }
}