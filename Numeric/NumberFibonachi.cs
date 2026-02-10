using System;

class Program
{
    public static void Main()
    {
        //0, 1, 1, 2, 3, 5, 8, 13, ...
        int number = 10;
        long a = 0;
        long b = 1;

        System.Console.WriteLine($"a : {a} , b : {b} ,");

        for(int i =2; i<number; i++)
        {
            long c = a + b;
            System.Console.WriteLine($"c : {c} ,");
            a = b;
            b = c;
        }
    }
}