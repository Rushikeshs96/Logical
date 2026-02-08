using System;

class Program
{
    public static void Main()
    {
        string str1 = "hello";
        string str2 = "oellh";

        //  [1] using charArray and sort function easy
        // char[] arr1 = str1.ToCharArray();
        // char[] arr2 = str2.ToCharArray();

        // arr1.Sort();
        // arr2.Sort();
        // var str3 = new string(arr1);
        // var str4 = new string(arr2);
        // if (str3 == str4)
        // {
        //     System.Console.WriteLine("anagram");
        // }
        // else
        // {
        //     System.Console.WriteLine("Not anagram");
        // }

        //[2] using Dictionary easy one

        Dictionary<char, int> map = new Dictionary<char, int>();

        if (str1.Length != str2.Length)
        {
            System.Console.WriteLine("Lenth not match. not an anagram");
        }

        foreach (char c in str1)
        {
            if (map.ContainsKey(c))
            {
                map[c]++;
            }
            else
            {
                map[c] = 1;
            }
        }

        foreach (char c in str2)
        {
            if (!map.ContainsKey(c))
            {
                System.Console.WriteLine("Not an anagram");
                return;
            }
            map[c] = map[c] - 1;

            if (map[c] == 0)
            {
                map.Remove(c);
            }
        }
        System.Console.WriteLine("anagram");
    }
}