using System;

class Program
{
    public static void Main()
    {
        string str = "I love CSharp";
        // expected output : "CSharp love I"

        // [1] using for loop and array
        string[] words = str.Split(" ");
        string result = "";

        // for (int i = words.Length - 1; i >= 0; i--)
        // {
        //     result += words[i] + " ";
        // }
        // System.Console.WriteLine(result);

        foreach (var w in words)
        {
            result += w + " ";
        }
        System.Console.WriteLine(result);
         

        // [2] using inbuilt method of array
        // string[] words = str.Split(" ");
        // words.Reverse();
        // string result = string.Join(" " , words);
        // System.Console.WriteLine(result);



        //ADVANCED REVERSE EACH CHAR IN WORD
        // string[] words = str.Split(" ");
        // string result = "";

        // foreach(var w in words)
        // {
        //     string reversedWord = "";
        //     foreach (var c in w)
        //     {
        //         reversedWord = c + reversedWord;
        //     }
        //     result += reversedWord + " ";
        // }
        // System.Console.WriteLine(result);


    }
}