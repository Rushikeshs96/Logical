using System;

class Program
{
    public static void Main()
    {
        string email = "test.email@example.com";
        bool isValid = IsValidEmail(email);

        Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
    }

    public static  bool IsValidEmail(string email)
    {
        if (!email.Contains("@"))
        {
            return false;
        }

        int atIndex = email.IndexOf('@');
        if (atIndex == 0 || atIndex == email.Length - 1)
            return false;

        string localPart = email.Substring(0, atIndex);
        string domainPart = email.Substring(atIndex + 1);

        if (!domainPart.Contains("."))
            return false;

        if (domainPart.StartsWith(".") || domainPart.EndsWith("."))
            return false;

        return true;
    }
}