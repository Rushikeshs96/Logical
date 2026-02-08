using System;
using System.Text;

class Program
{
    public static void Main()
    {
         string input = "a3b2c1";
         StringBuilder result = new StringBuilder();

        char currentChar = '\0';

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                currentChar = c;
            }
            if (char.IsDigit(c))
            {
                int count = c - '0';

                for (int i = 0; i < count; i++)
                {
                    result.Append(currentChar);
                }
            }
        }
        System.Console.WriteLine(result.ToString());
    }
}