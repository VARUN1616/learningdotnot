using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 5, 18, 23, 53, 46, 42 };
            //Console.WriteLine(numbers[6].ToString());

            //string[] names = new string[] { "mahesh", "varun", "dj", "ronaq" };
            ////Console.WriteLine(names[2]);
            //foreach (String name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            string statement = "mahesh chutiya tha" + 
                " ,chutiya hai aur chutiya hi rahega";
            char[] charArray = statement.ToCharArray();
            Array.Reverse(charArray);

            foreach(char newstatement in charArray)
            {
                Console.Write(newstatement);
            }
            Console.ReadLine();
        }
    }
}
