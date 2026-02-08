using System;
using System.Text;

class Program
{
    public static void Main()
    {
        // [1] using linq
        // string str = "lol";
        // var reverse = new string(str.Reverse().ToArray());
        // if (str == reverse)
        // {
        //     Console.WriteLine("string is pallindrome");
        // }
        // else
        // {
        //     Console.WriteLine("string is not pallindrome");
        // }


        //[2] two points while loop way
        // string str = "lol";
        // int left = 0;
        // int right = str.Length - 1;
        // bool isPallindrome = true;
        // while (left < right)
        // {
        //     if (str[left] != str[right])
        //     {
        //         isPallindrome = false;
        //         break;
        //     }
        //     left++;
        //     right--;
        // }
        // Console.WriteLine(isPallindrome ? "Palindrome" : "Not Palindrome");

        // [3] two points way - for loop
        // string str = "loll";
        // bool isPallindrome = true;

        // for (int i = 0; i < str.Length / 2; i++)
        // {
        //     if (str[i] != str[str.Length - 1 - i])
        //     {
        //         isPallindrome = false;
        //         break;
        //     }
        // }
        // System.Console.WriteLine(isPallindrome ? "Pallindrome" : "Not pallindrpme");

        //[4] using stringbuilder
        // string str = "loll";
        // StringBuilder sb = new StringBuilder();

        // for(int i = str.Length-1; i>=0; i--)
        // {
        //     sb.Append(str[i]);
        // }
        // System.Console.WriteLine(str== sb.ToString()? "Pallindrome" : "Not pallindrome");

        //  [5] ignoring spaces and cases
        string input = "Never odd or even";
        string cleaned = new string(input.ToLower()
                        .Where(char.IsLetterOrDigit)
                        .ToArray());
        string reversed = new string(cleaned.Reverse().ToArray());
        System.Console.WriteLine(input == reversed ? "Pallindrome": "not pallindrome");
    }
}