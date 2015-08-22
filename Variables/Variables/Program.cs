using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 7;
            int y = x + 3;
            Console.WriteLine(y);
           
            */

            //String myFirstName = "Varun";
            //Console.WriteLine(myFirstName);

            int x = 7;
            //string y = "bob";
            String y = "5";

            string firstTry = x.ToString()  + y;
            int secondTry = x + int.Parse(y);
            Console.WriteLine(firstTry);
            Console.WriteLine(secondTry);
            Console.ReadLine();
        }
    }
}
