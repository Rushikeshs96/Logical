using System;

class Program
{
    public static void Main()
    {
        string input = "hello";

        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (map.ContainsKey(c))
            {
                map[c]++;
            }
            else
            {
                map[c] = 1;
            }
        }
        foreach(var c in map)
        {
            if (c.Value > 1)
            {
                System.Console.WriteLine($"character : {c.Key} - {c.Value}");
            }
        }
    }
}