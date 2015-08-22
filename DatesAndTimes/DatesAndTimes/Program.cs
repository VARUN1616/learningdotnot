using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            DateTime myBirthday = DateTime.Parse("05/03/1989");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            
            Console.ReadLine(); 

        }
    }
}
