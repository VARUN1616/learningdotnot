using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = mySecretFormulae("World");
            Console.WriteLine(value);
            Console.ReadLine();
        }

        private static string mySecretFormulae()
        {
            return "Hello World!!";
        }

        private static string mySecretFormulae(string name)
        {
           // return "hello , " + name;
            return string.Format("hello , {0} ", name);
            
        }
    }
}
