using System;

class Program
{
    public static void Main()
    {
        int n = 5;
        // 1
        // 1 2
        // 1 2 3
        // 1 2 3 4
        // 1 2 3 4 5

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }


        // 1
        // 2 2
        // 3 3 3
        // 4 4 4 4
        // 5 5 5 5 5

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // 1 2 3 4 5
        // 1 2 3 4
        // 1 2 3
        // 1 2
        // 1


        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }


        //     1
        //    1 2
        //   1 2 3
        //  1 2 3 4
        // 1 2 3 4 5

        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j > i; j--)
                Console.Write(" ");

            for (int k = 1; k <= i; k++)
                Console.Write(k + " ");

            Console.WriteLine();
        }




    }
}