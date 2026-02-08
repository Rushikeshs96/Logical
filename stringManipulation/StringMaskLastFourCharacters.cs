using System;
using System.Text;

class Program
{
    public static void Main()
    {
        string input = "9876543210";
        // StringBuilder sb = new StringBuilder(input);

        // for (int i = input.Length - 4; i < input.Length; i++)
        // {
        //     sb[i] = '*';
        // }
        // System.Console.WriteLine(sb.ToString());


       // [2] using substring
        if (input.Length < 4)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        string masked =
            input.Substring(0, input.Length - 4) + "****";

        Console.WriteLine(masked);
    }
}