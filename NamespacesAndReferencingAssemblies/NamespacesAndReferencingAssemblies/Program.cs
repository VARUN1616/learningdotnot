﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Tabor;

namespace NamespacesAndReferencingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
           // System.IO.StreamReader myStreamReader = new System.IO.StreamReader();

           //StreamReader myStreamReader = new StreamReader();

            Bob bob = new Bob();

            string html = bob.Lookup("https://google.com");
            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}