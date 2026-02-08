using System;

class Program
{
    public static void Main()
    {
        string sentence = "Remove a specific word from a sentence";
        string wordToRemove = "specific";

        string[] arr = sentence.Split(' ');
        string result = "";
        foreach (string word in arr)
        {
            if (word != wordToRemove)
            {
                result = result + word;
                result = result + " ";
            }
        }
        System.Console.WriteLine(result);
    }
}