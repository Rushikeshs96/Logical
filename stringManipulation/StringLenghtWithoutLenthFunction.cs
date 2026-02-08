using System;

class Program
{
    public static void Main()
    {
        string str = "this is string";
        int count = 0;
        //[1] using foreach loop
        // foreach (var c in str)
        // {
        //     if(char.IsLetter(c))
        //     count++;
        // }
        // Console.WriteLine(count);

        //[2] using tocharArray
        // char[] charArray = str.ToCharArray();
        // foreach (char c in str)
        // {
        //     if(char.IsLetter(c))
        //     count++;
        // }
        // Console.WriteLine(count);

        //[3] using linq
        count = str.Count(c=> c !=' ');
        System.Console.WriteLine(count);
    }
}