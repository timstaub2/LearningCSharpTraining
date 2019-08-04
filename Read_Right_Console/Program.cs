using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Please enter your First name");
        String FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your Last name");
        String LastName = Console.ReadLine();

        //Console.WriteLine("Hello " + UserName);

        Console.WriteLine("Hello {0}, {1}", FirstName, LastName);
        }
    }
