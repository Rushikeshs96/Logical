using System;

class Program
{
    public static void Main()
    {
        int number = 10;
        long fact = 1;                       //always initialize with 1 in case of factorial

        for (int i = 1; i <= number; i++)  //always initialize  i with 1  in case of factorial
        {
            fact = fact * i;
        }
        System.Console.WriteLine(fact);
    }
}