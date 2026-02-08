using System;

class Program
{
    public static void Main()
    {
        string input = "pwwkew";
        //output = wke
        HashSet<char> set = new HashSet<char>();

         int maxLength = 0;
        int start = 0;

        for (int i = 0; i < input.Length; i++)
        {
            while (set.Contains(input[i]))
            {
                set.Remove(input[start]);
                start++;
            }

            set.Add(input[i]);
            maxLength = Math.Max(maxLength, set.Count);
        }

        Console.WriteLine(maxLength);

    }
}