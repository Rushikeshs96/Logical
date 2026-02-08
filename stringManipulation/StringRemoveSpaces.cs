using System;
using System.Text;

class Program
{
    public static void Main()
    {
        string str = "Hello World From CSharp";

        //[1] using replace function
        // var newString = str.Replace(" ", ""); 
        // System.Console.WriteLine(newString);

        //[2] using linq
        // var newString = new string(str.Where(s => !char.IsWhiteSpace(s)).ToArray());
        // System.Console.WriteLine(newString);

        //[3] using stringbuilder
        StringBuilder sb = new StringBuilder();
        foreach (var s in str)
        {
            if (s != ' ')
            {
                sb.Append(s);
            }
        }
        string data = sb.ToString();
        System.Console.WriteLine(data);
    }
}