using System;

class Program
{
    public static void Main()
    {
        string str = "helloworld";
        char target = 'o';
        int count = 0;
        foreach (char c in str)
        {
            if (c == target)
            {
                count++;
            }
        }
        System.Console.WriteLine(count);
    }
}