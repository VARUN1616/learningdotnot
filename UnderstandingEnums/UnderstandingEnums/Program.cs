using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("Hello World!!");
            SuperHero myValue;
            Console.WriteLine("Enter the Superhero and get its nik name");
            string enteredValue=Console.ReadLine();
            if (Enum.TryParse<SuperHero>(enteredValue, true, out myValue))
            {
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("dnsladnf;nad");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("akdfdalkfdakjsf");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("mbfcadsmbfdsbaf");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Bevkoof");
            }
            Console.ReadLine();

        }
        enum SuperHero
        {
            Batman,
            Superman,
            GreenLantern
        }
    }
}
