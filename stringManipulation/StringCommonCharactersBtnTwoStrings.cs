using System;
using System.Security.AccessControl;

class Program
{
    public static void Main()
    {
        string s1 = "programming";
        string s2 = "gaming";

        // HashSet<char> set = new HashSet<char>(s1);
        // HashSet<char> common = new HashSet<char>();

        // foreach(var c in s2)
        // {
        //     if (set.Contains(c))
        //     {
        //         common.Add(c);
        //     }
        // }
        // foreach(var c in common)
        // {
        //     System.Console.WriteLine(c);
        // }


        //[2] using linq
        var commonChars = s1.Intersect(s2);

        foreach (char c in commonChars)
        {
            Console.WriteLine(c);
        }
    }
}