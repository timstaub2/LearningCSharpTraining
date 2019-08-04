using System;

namespace Datatype_Conversion
{
    class Program
    {
        static void Main()
        {
            //int i = 100;
            //float f = i;
            //float f = 123.45F;
            //int i = (int)f;
            //int i = Convert.ToInt32(f);

            string strNumber = "77896589";
            //int i = int.Parse(strNumber);
            int Result = 0;
            bool IsConversionSuccessful = int.TryParse(strNumber, out Result);
            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
