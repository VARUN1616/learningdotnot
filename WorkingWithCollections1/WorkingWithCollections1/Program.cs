using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Car c1 = new Car();
             c1.Make = "BMW";
             c1.Model = ";as;dmlaksd";
             Car c2 = new Car();
             c2.Make = "Audi";
             c2.Model = "lhsalfhdhas;la";
             List<Car> myList = new List<Car>();
              myList.Add(c1);
             myList.Add(c2);
             */

            /*
            Car c1 = new Car { Make = "BMW", Model = "sdalhfldl" };
            Car c2 = new Car { Make = "Audi", Model = "asma;lkmda;md" };

            List<Car> myList = new List<Car>();
            myList.Add(c1);
            myList.Add(c2);
            */
            List<Car> myList = new List<Car>(){ new Car{ Make="BMW",Model="l,bansd,basnd"},
                new Car{Make = "Audi",Model = "knafdlandfna"}
            };

            foreach (Car car in myList)
            {
                Console.WriteLine("Make = {0} , Model = {1} ", car.Make, car.Model);
            }
            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
