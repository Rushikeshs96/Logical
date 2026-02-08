using System;
using System.Text;

class Program
{
    public static void Main()
    {
        string str = "HELLO WORLD";
        char[] result = str.ToCharArray();

        //[1] using asci and for loop

        // for (int i = 0; i < result.Length; i++)
        // {
        //     if (result[i] >= 'A' && result[i] <= 'Z')
        //     {
        //         result[i] = (char)(result[i] + 32);
        //     }
        // }
        // string lower = new string(result);
        // System.Console.WriteLine(lower);

        //[2] using stringbuilder and foreach

        StringBuilder sb = new StringBuilder();
        foreach (var s in str)
        {
            if (s >= 'A' && s <= 'Z')
            {
                sb.Append((char)(s + 32));
            }
            else
            {
                sb.Append(s);
            }
        }
        var output = sb.ToString();
        System.Console.WriteLine(output);
    }
}