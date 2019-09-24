using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main()
            
        {
            Console.WriteLine("please enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            //if (UserNumber == 10)
            //{
            //    Console.WriteLine("Your number is 10");
            //}
            //else if (UserNumber == 20)
            //{
            //    Console.WriteLine("Your number is 20");
            //}
            //else if (UserNumber == 30)
            //{
            //    Console.WriteLine("Your number is 30");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is not listed in group.");
            //}

            switch(UserNumber)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not in the group");
                    break;
            }
        }
    }
}
