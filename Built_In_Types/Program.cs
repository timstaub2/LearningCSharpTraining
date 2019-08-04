using System;

namespace Built_In_Types
{
    class Program
    {
        static void Main()
        {
            //string Name = "\"Timothy\"";
            //Console.WriteLine(Name);

            //Escape Sequences 
            //string Name = "One\nTwo\nThree";

            //verbatim literal
            //string Name = "C:\\Users\\timst\\Source\\Repos\\timstaub2\\LearningCSharpTraining";
            string Name = @"C:\Users\timst\Source\Repos\timstaub2\LearningCSharpTraining";
            Console.WriteLine(Name);
        }
    }
}
