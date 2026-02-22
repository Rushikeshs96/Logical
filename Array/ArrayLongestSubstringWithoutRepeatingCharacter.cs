using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = "abcabcbb";

        HashSet<char> set = new HashSet<char>();

        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            while (set.Contains(s[i]))
            {
                set.Remove(s[start]);
                start++;
            }

            set.Add(s[i]);

            int length = i - start + 1;

            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        Console.WriteLine("Longest Length: " + maxLength);
    }
}