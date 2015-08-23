using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.DoSomething();
            Console.ReadLine();
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(this.helperMethod());
        }
        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
