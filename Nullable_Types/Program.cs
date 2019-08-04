using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main()
        {
            //bool? AreYouMajor = true;
            //if (AreYouMajor == true)
            //{
            //    Console.WriteLine("User is Major");
            //}
            //else if (AreYouMajor == false)
            //{
            //    Console.WriteLine("User is not Major");
            //}
            //else
            //{
            //    Console.WriteLine("User did not answer the question");
            //}
            int? TicketsOnSale = 100;
            int AvailableTickests =  TicketsOnSale ?? 0;
            //if (TicketsOnSale == null)
            //{
            //    AvailableTickests = 0;
            //}
            //else
            //{
            //    AvailableTickests = (int)TicketsOnSale;
            //}

            Console.WriteLine("Available Tickets for Sale = {0}", AvailableTickests);
        }
    }
}
