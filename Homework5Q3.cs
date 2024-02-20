using System;

class Program
{
    static void Main()
    {
        createAccount();
    }

    static bool checkAge(int birthYear)
    {
        int age = DateTime.Now.Year - birthYear;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter password again:");
        string password2 = Console.ReadLine();

        if (password1 != password2)
        {
            Console.WriteLine("Passwords do not match. Account creation failed.");
            return;
        }

        Console.WriteLine("Enter birth year:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        if (!checkAge(birthYear))
        {
            Console.WriteLine("You must be at least 18 years old to create an account. Account creation failed.");
            return;
        }

        Console.WriteLine("Account is created successfully");
    }
}
