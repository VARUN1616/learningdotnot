using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type Superhero's name to see his nick name");
            string userValue = Console.ReadLine();

            switch (userValue.ToUpper())
            {
                case "BATMAN":
                    Console.WriteLine("safdhngkanf;la");
                    break;
                case "SUPERMAN":
                    Console.WriteLine("kbksabdfvkjdbasf");
                    break;
                case "GREENLANTERN":
                    Console.WriteLine("ndsakfbkajsdfjas");
                    break;

                default:
                    Console.WriteLine("Bevkoof");
                    break;
            }

            Console.ReadLine();
        }
    }
}
