using System;

class Program
{
    public static void Main()
    {
        //Number = 12
        //Factors = 1, 2, 3, 4, 6, 12

        int number = 12;

        for(int i=1; i <= number; i++)
        {
            if(number % i == 0)
            {
                System.Console.WriteLine("factor is"+ i);
            }
        }
    }
}