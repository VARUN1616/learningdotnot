using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.Display();
            Car myCar = new Car();
            Car myCar2 = new Car("BMw", "asdsad", "white", 2001);
            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Originalvalue { get; set; }

        public Car()
        {
            this.Make = "Make";

        }
        public Car(string make, string model, string color, int year)
        {
            this.Make = make;
            this.Color = color;
            this.Year = year;
            this.Model = model;
        }
        public static void Display()
        {
            Console.WriteLine("Car class");
        }
    }
}
