﻿using System;

    class Program
    {
        static void Main()
        {
        string UserChoice = string.Empty;
        do
        {
            Console.WriteLine("Please enter your target.");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start = Start + 2;
            }
            
            do
            {
                Console.WriteLine("Do you want to continue - Yes or No?");

                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice, Please say yes or No");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");
        } while(UserChoice == "YES");
        }
    }

