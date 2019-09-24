using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your target.");

        int UserTarget = int.Parse(Console.ReadLine());

        int Start = 0;

        while (Start <= UserTarget)
        {
            Console.Write(Start + " ");
            Start = Start + 2;
        }

    }
}
