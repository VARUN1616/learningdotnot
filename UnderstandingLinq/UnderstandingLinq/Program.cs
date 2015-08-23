using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myList = new List<Car>(){ new Car{ Make="BMW",Model="l,bansd,basnd",Color=CarColor.Black,Price = 12345,Year=1995},
                new Car{Make = "Audi",Model = "knafdlandfna" ,Color = CarColor.Blue,Price = 98765,Year = 2001},
                new Car{Make = "BMW",Model = "chuchu" ,Color = CarColor.White,Price = 34567 ,Year = 2010},
                new Car{Make = "Honda",Model = "pupu" ,Color = CarColor.Gray,Price = 123,Year = 1998},
                new Car{Make = "Audi",Model = "lului" ,Color = CarColor.Blue,Price = 98765,Year = 2001}
            };

            //Linq = Line Integrated Query example as follows

           /* var bmws = from car in myList
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */
           /* var bmws = from car in myList
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make,car.Model,car.Year};


            var orderedCars= from car in myList
                             orderby car.Year descending
                             select car;
            */

            //Different way of using Linq using lambda

            var _bmws = myList.Where(p => p.Year == 2010).Where(p => p.Make == "BMW");
            var _orderedCars = myList.OrderBy(p => p.Year);

            foreach (var item in _orderedCars)
            {
                Console.WriteLine("Make : {0} Model : {1} Year : {2}", item.Make, item.Model, item.Year);
            }


           /* foreach (var item in myList)
            {
                Console.WriteLine("Make : {0} Model : {1} Year : {2}",item.Make,item.Model,item.Year);
            }
            */
            
            Console.ReadLine();
        }
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Price { get; set; }
            public int Year { get; set; }
            public CarColor Color { get; set; }
        }
        enum CarColor
        {
            Black,
            Blue,
            White,
            Gray,
            Silver
        }
    }
}
