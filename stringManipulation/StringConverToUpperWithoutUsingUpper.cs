using System;
using System.Data.Common;
using System.Text;

class Program
{
    public static void Main()
    {
        string str = "hello world";
        char[] result = str.ToCharArray();

        //[1] for loop and asci value logic

        // for(int i=0; i < result.Length; i++)
        // {
        //     if(result[i] >= 'a' && result[i] <= 'z')
        //     {
        //         result[i] = (char)(result[i] - 32);
        //     }
        // }
        // string upper = new string(result);
        // System.Console.WriteLine(result);

        StringBuilder sb = new StringBuilder();
        foreach (var c in str)
        {
            if (c >= 'a' && c <= 'z')
            {
                sb.Append((char)(c - 32));
            }
            else
            {
                sb.Append(c);
            }
        }
        string upper = sb.ToString();
        System.Console.WriteLine(upper);
    }
}