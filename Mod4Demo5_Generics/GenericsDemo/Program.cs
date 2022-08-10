using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // This is us creating an instance of our custom
            // generic class we created in the class1.cs file
            // replacing the data type with 'int'. We can also do this 
            // with any other datatype
         
            int i = 1; 
            int j = 2;
            Swap<int> swapInt = new Swap<int>();
            swapInt.SwapData(ref i, ref j);

            // We can do this with a float too. 
            Swap<float> swapFloat = new Swap<float>();


            Queue<int> queue = new Queue<int>(); // FIFO
            // enqueue and dequeue 
            Stack<int> stack = new Stack<int>(); // LIFO
            // push and pop

            SortedDictionary<string, car> carDictionary = new SortedDictionary<string, car>();

            // This is the key, the vin                    // this is the value(s)
            carDictionary.Add("Z1234F", new car() { VIN = "Z1234F", Make = "BMW   ", Model = "3Series", Price = 123451 });
            carDictionary.Add("Z1234D", new car() { VIN = "Z1234D", Make = "VW    ", Model = "Bug" });
            carDictionary.Add("Z1234E", new car() { VIN = "Z1234E", Make = "Mazda ", Model = "3" });
            carDictionary.Add("Z1234G", new car() { VIN = "Z1234G", Make = "Suburu", Model = "Imprezza" });
            carDictionary.Add("Z1234A", new car() { /*VIN = "Z1234A",*/ Make = "Ford  ", Model = "F150" });

            //Console.WriteLine(carDictionary.ContainsKey("Z1234E"));
          
            car car4 = new car() { VIN = "CDD4G", Make = "Honda", Model = "CRV", Price = 1234123};
            carDictionary.Add(car4.VIN, car4);

            foreach (var car in carDictionary.Values)
            {
                Console.WriteLine($"Car VIN :{car.VIN} || Make :{car.Make} || Model : {car.Model}");
            }
            Console.WriteLine("Enter the VIN to search the car:");
            string VIN = Console.ReadLine();
            if (carDictionary.ContainsKey(VIN))
            {
                Console.WriteLine($"{carDictionary[VIN].Model} , { carDictionary[VIN].Make} , {carDictionary[VIN].Price}");
            }
            else
            {
                Console.WriteLine("No match found");
            }
            Console.ReadLine();

            foreach (var car2 in carDictionary)
            {
                Console.WriteLine(car2);
            }
            Console.ReadLine();
        }
    }
}
