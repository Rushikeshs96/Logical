using System;

class Program
{
    static void Main()
    {
        int number = 1234;

        if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        else
        {
            Console.WriteLine(NumberToWords(number));
        }
    }

    static string NumberToWords(int number)
    {
        string[] ones =
        {
            "", "One", "Two", "Three", "Four",
            "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        string[] tens =
        {
            "", "", "Twenty", "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        string words = "";

        if (number >= 1000)
        {
            words += ones[number / 1000] + " Thousand ";
            number %= 1000;
        }

        if (number >= 100)
        {
            words += ones[number / 100] + " Hundred ";
            number %= 100;
        }

        if (number >= 20)
        {
            words += tens[number / 10] + " ";
            number %= 10;
        }

        if (number > 0)
        {
            words += ones[number] + " ";
        }

        return words.Trim();
    }
}
