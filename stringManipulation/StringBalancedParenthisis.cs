using System;

class Program
{
    public static void Main()
    {
        string input = "(a+b)*(c-d)";

        Stack<char> stack = new Stack<char>();
        bool isBalanced = true;
        foreach (var c in input)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if(c == ')')
            {
                if(stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }
                stack.Pop();
            }
        }
        
        if (stack.Count != 0)
            isBalanced = false;

        Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");
    }
}