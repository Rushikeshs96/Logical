using System;

class Program
{
    public static void Main()
    {
        string input = "Hello World! 123";
        int vowels = 0;
        int consonants = 0;
        int digits = 0;
        int special = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c) && "aeiou".Contains(c))
            {
                vowels++;
            }
            if (char.IsLetter(c) && !"aeiou".Contains(c))
            {
                consonants++;
            }
            if (char.IsDigit(c))
            {
                digits++;
            }
            if(!char.IsLetterOrDigit(c))
            {
                special++;
            }
        }
        System.Console.WriteLine($"Vowels - {vowels}, Consonent - {consonants}, digits - {digits}, special - {special}");
    }
}