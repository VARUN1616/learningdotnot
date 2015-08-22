using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Value.txt");
            string line = "";
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                    Console.ReadLine();
                }
            }
            myReader.Close();
            
        }
    }
}
