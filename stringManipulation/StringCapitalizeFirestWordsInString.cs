using System;
using System.Text;

class Program
{
    public static void Main()
    {
        string input = "hello world from csharp";
        StringBuilder result = new StringBuilder();
        bool newWord = true;

        foreach (char c in input)
        {
            if (c == ' ')
            {
                newWord = true;
                result.Append(c);
            }
            else
            {
                if (newWord)
                {
                    result.Append(char.ToUpper(c));
                    newWord = false;
                }
                else
                {
                    result.Append(c);
                }
            }
        }
        System.Console.WriteLine(result);
    }
}