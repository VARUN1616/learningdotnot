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
            try
            {

                StreamReader myReader = new StreamReader("Value.txt");
                string line = "";
                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);

                    }
                }
                myReader.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Does not Exists");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exists");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong : {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Inside the Finally Block");
            }
            Console.ReadLine();
        }
    }
}
