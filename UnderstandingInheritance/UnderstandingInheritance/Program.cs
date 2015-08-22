using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "lhgi1232";
            myCar.Year = 2001;
            myCar.Color = "Grey";

            PrintVehicledetails(myCar);
            Console.ReadLine();

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "gti123";
            myTruck.Year = 2010;
            myTruck.Color = "Brown";
            myTruck.CapacityinTons = 1234567;

            PrintVehicledetails(myTruck);
            Console.ReadLine();
        }
        public static void PrintVehicledetails(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle details  : {0}",vehicle.FormatMe());
        }
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public abstract string FormatMe();
    }

    class Car:Vehicle
    {
        
        public override string FormatMe()
        {
            return string.Format("{0} - {1} - {2}", this.Make, this.Model, this.Year);
        }
    }

    sealed class Truck : Vehicle
    {
        public int CapacityinTons { get; set; }
        public override string FormatMe()
        {
            return string.Format("{0} - {1} - {2} Tonnes", this.Make, this.Model, this.CapacityinTons);
        }
    }

    /*
     class semi : Truck
    {

    }
     * */
}
