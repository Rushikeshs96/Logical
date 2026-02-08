using System;
class Program
{
    public static void Main()
    {
        //[1] using split
        string input = "Hello World from C Sharp";
        // int number = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        // System.Console.WriteLine(number);

        //[2] using for loop
        int count = 0;
        bool inWord = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }
        System.Console.WriteLine(count);
    }
}