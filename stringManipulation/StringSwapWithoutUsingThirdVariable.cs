using System;

class Program
{
    public static void Main()
    {
        string a = "Hello";
        string b = "World";

        // a = a + b;                               //HelloWorld
        // b = a.Substring(0, a.Length - b.Length); // Hello
        // a = a.Substring(b.Length);               //World
        // Console.WriteLine($"a = {a}, b = {b}");


        // a = a + b;
        // b = a.Replace(b, "");
        // a = a.Replace(b, "");
        // Console.WriteLine($"a = {a}, b = {b}");

        //using Tuple easiest

        (a, b) = (b, a);
        Console.WriteLine($"a = {a}, b = {b}");


    }
}