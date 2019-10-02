using System;
using While_Loop;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your total amount.");

        decimal enteredAmount = decimal.Parse(Console.ReadLine());

        decimal saleTax = ComputeTax.Compute(enteredAmount);

        Console.WriteLine("Total tax amount is " + saleTax.ToString("C"));

    }
}
