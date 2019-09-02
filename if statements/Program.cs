using System;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("What state are you from?");
        
        var getStateCode = (Console.ReadLine());


        if (getStateCode == "MI" | getStateCode == "AL")

            Console.WriteLine("We are the Champions!");
        else
            Console.WriteLine("Just a bunch of loosers!");

        }
    }

