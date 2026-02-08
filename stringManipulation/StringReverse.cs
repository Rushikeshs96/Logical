using System;
using System.Text;

class Program
{
    public static void Main()
    {
        //[1] built in way
        // Console.WriteLine("Enter string to reverse : ");
        // var originalString = Console.ReadLine();

        // char[] charArray = originalString.ToCharArray();

        // Array.Reverse(charArray);

        // string reversedString = new string(charArray);

        // Console.WriteLine($"Reversed string is :{reversedString}");


        //[2] stringBuilder way

        // string original = "i am rushikesh";

        // StringBuilder str = new StringBuilder(original.Length);
        // for (int i = original.Length - 1; i >= 0; i--)
        // {
        //     str.Append(original[i]);
        // }
        // Console.WriteLine("Reversed String = "+ str );


        //[3] TwoPointer way

        // string str = "lets do this";
        // char[] charArray = str.ToCharArray();
        // int left = 0;
        // int right = str.Length - 1;

        // while (left < right)
        // {
        //     char tempData = charArray[left];
        //     charArray[left] = charArray[right];
        //     charArray[right] = tempData;

        //     left++;
        //     right--;
        // }

        // var reversedString = new string(charArray);
        // Console.WriteLine($"Reversed string : {reversedString}");

        //[4] Two pointer way using for loop
        // string str = "hello";
        // char[] cArray = str.ToCharArray();

        // for (int i = 0; i < cArray.Length / 2; i++)
        // {
        //     char temp = cArray[i];
        //     cArray[i] = cArray[cArray.Length - 1 - i];
        //     cArray[cArray.Length - 1 - i] = temp;
        // }
        // var reverse = new string(cArray);
        // Console.WriteLine(reverse);

        //[5] Using linq
        // string str = "hello";
        // var reverse = new string(str.Reverse().ToArray());
        // Console.WriteLine(reverse);

    }
}
