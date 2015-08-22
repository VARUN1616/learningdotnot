using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the value and press Enter.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("The Entered Value is : " + userValue);
            //Console.ReadLine();

            Console.WriteLine("Please select 1,2 or 3 ?");
            string userValue;
            userValue = Console.ReadLine();
            //if (userValue == "1")
            //{
            //    Console.WriteLine("you won  a car");
            //}
            //else if (userValue == "2")
            //{
            //    Console.WriteLine("you won a mobile");
            //}
            //else if (userValue == "3")
            //{
            //    Console.WriteLine("you won a cat");
            //}
            //else
            //{
            //    Console.WriteLine("you Lost");
            //}
            string message = (userValue == "1") ? "boat" : "bevkoof";
            Console.WriteLine("You won {0}",message);
            Console.ReadLine();
        }
    }
}
