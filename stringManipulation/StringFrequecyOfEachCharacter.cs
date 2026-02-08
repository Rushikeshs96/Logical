using System;

class Program
{
    public static void Main()
    {
        string input = "swiss";
        Dictionary<char, int> dic = new Dictionary<char, int>();

        foreach (var c in input)
        {
            if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic[c] = 1;
            }
        }
        
        foreach(var word in dic)
        {
            System.Console.WriteLine($"word - {word.Key} : value - {word.Value}");
        }
    }
}