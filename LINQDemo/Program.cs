using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sql SERVER
            //"select * from Cars where Make ='Honda'";
            // max , min, count

            List<Car> cars = new List<Car>();

            cars.Add(new Car { VIN = "A2", Make = "Ford", Model = "Explorer", Year = 2019, Price = 25000 });
            cars.Add(new Car { VIN = "B4", Make = "Honda", Model = "HRV", Year = 2020, Price = 35000 });
            cars.Add(new Car { VIN = "A34", Make = "Honda", Model = "CRV", Year = 2021, Price = 45000 });
            cars.Add(new Car { VIN = "K2", Make = "Tesla", Model = "Y", Year = 2020, Price = 65000 });
            cars.Add(new Car { VIN = "A2", Make = "BMW", Model = "745I", Year = 2018, Price = 55000 });
            cars.Add(new Car { VIN = "T2", Make = "Audi", Model = "Q5", Year = 2017, Price = 65000 });

            // LINQ : deferred query execution : not executed unless you use the result
            //var hondas = from c in cars // c is temp variable in list
            //             where c.Make == "Honda" // condition
            //             select c; // select 

            // forced query execution
            var hondas = (from c in cars // c is temp variable in list
                          where c.Make == "Honda" // condition
                          select c).ToList(); // select 


            Console.WriteLine("List of Hondas");
            cars.Add(new Car { VIN = "F34", Make = "Honda", Model = "CRV", Year = 2018, Price = 44400 });

            
            foreach(var h in hondas)
            {
                Console.WriteLine($"Make :{h.Make} , Model :{h.Model}");
            }
            
            // sql injection attacks
            // left hand side : view
            var orderedCars=from c in cars
                            orderby c.Price ascending
                            select c;
            foreach(var car in orderedCars)
            {
                Console.WriteLine($"Car Make :{car.Make} , Model :{car.Model} , Price:{car.Price} ");
            }
           
            var bmwsList = from c in cars
                           where c.Make == "BMW" && c.Year == 2018
                           select c;
            Console.WriteLine("List of BWMs in 2018:");
            foreach(var bmws in bmwsList)
            {
                Console.WriteLine($"BMW Price : {bmws.Price} Model: {bmws.Model}");
            }
            
            // anonymous type

            var cars2020 = (from c in cars
                           where c.Year ==2020
                           select c).Count();
            Console.WriteLine($"Number of cars in 2020  are: {cars2020}");

            
            // 
            var ford= cars.FindAll(c => c.Make == "Ford" && c.Year==2018 );
            var maxPrice= cars.Max(c => c.Price); // lamda

            // linq
            var maxpricedcar=from c in cars
                             where c.Price == maxPrice
                             select c;

            foreach(var c in maxpricedcar)
            {
                Console.WriteLine($"Make : {c.Make} model: {c.Model} price: {c.Price}");
            }

            Console.ReadLine();
        }
    }
}
