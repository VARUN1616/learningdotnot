using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //String myString = "C:\\ Drive";

            //String myString = string.Format("{0}", "Bob");
            //String myString = string.Format("{0:C}", 123.234);
            //String myString = string.Format("Phobe  Number : {0:(+##) #####-#####}", 917736897597);

            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString = myString + "--" + i.ToString();
            //}

            //StringBuilder myString = new StringBuilder();
            //for (int i = 0; i < 100; i++)
            //{
            //    myString.Append("--");
            //    myString.Append(i);
            //}

            string myString = "  Mahesh Chutiya tha ,Chutiya hai ,Aur chutiya hi rahega  ";
            myString = string.Format("Before trim :{0}  After Trim :{1}", myString.Length, myString.Trim().Length);
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
