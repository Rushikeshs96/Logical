using System;
using System.Text;

class Program
{
    public static void Main()
    {
        string input = "aaabbc";
        StringBuilder result = new StringBuilder();
        char prev = input[0];
        int count = 0;

        foreach (char c in input)
        {
            if (c == prev)
            {
                count++;
            }
            else
            {
                result.Append(prev);
                result.Append(count);

                prev = c;
                count = 1;
            }
        }
        result.Append(prev);
        result.Append(count);
        System.Console.WriteLine(result.ToString());
    }
}