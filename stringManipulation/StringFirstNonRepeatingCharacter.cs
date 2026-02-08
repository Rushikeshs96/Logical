using System;

class Program
{
    public static void Main()
    {
        string str = "swiss";
        //expected = w

        // [1] using dictionary
        // Dictionary<char, int> dic = new Dictionary<char, int>();
        // foreach (var c in str)
        // {
        //     if (dic.ContainsKey(c))
        //     {
        //         dic[c]++;
        //     }
        //     else
        //     {
        //         dic[c] = 1;
        //     }
        // }

        // foreach(var c in str)
        // {
        //     if(dic[c]== 1)
        //     {
        //         Console.WriteLine(c);
        //         break;
        //     }
        // }

        // [2] using linq
        char result = str
                   .GroupBy(c => c)
                   .Where(c => c.Count() == 1)
                   .Select(c => c.Key)
                   .FirstOrDefault();

        System.Console.WriteLine(result);


    }
}