using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();
            myNewCar.Color = "Silver";
            myNewCar.Make = "BMW";
            myNewCar.Model = "idk";
            myNewCar.Year = 1900;

            Console.WriteLine("{0} - {1} - {2}",myNewCar.Color,myNewCar.Model,myNewCar.Make);
            //Console.WriteLine(myNewCar);

            //double marketValue = determineMarketValueOfCar(myNewCar);
            //Console.WriteLine(marketValue);

            Console.WriteLine("Car Value : {0}", myNewCar.marketValueOfCar());
            Console.ReadLine();
        }

        private static double determineMarketValueOfCar(Car car)
        {
            double carValue = 100.0;
            return carValue;
        }
    }


    class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double marketValueOfCar()
        {
            double myValue;
            if(this.Year >= 1998)
            {
                myValue = 20000.0;
            }
            else
            {
                myValue = 1000.0;
            }

            return myValue;
        }

    }
 

}
