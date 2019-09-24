﻿using System;

class Program
{
    static void Main()
    {
        int TotalCoffeeCost = 0;

        Start:
        Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid", UserChoice);
                goto Start;
        }
        Decide:
        Console.WriteLine("Do you want to buy another coffee - Yes or No?");
        string UserDecision = Console.ReadLine();

        switch(UserDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Your choice is not valid", UserDecision);
                goto Decide;
        }
        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Bill Amount = ${0}.00", TotalCoffeeCost);
    }
}

