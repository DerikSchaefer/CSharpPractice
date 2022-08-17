using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    interface CRUD
    {


        void AddRecord(Car car);

        void DeleteRecord(Car car);

        ICollection<Car> GetAllRecords();

        Car FindCar(string VIN);

        void UpdateRecord(string VIN, Car car);


        ICollection<Car> GetAllCars();


    }

    class CarRepository : CRUD
    {
        PCAD7CarsEntities entities;

        public CarRepository()
        {
            entities = new PCAD7CarsEntities();
        }
       
        public void AddRecord(Car car)
        {
            entities.Cars.Add(car); 
            entities.SaveChanges(); 
        }

        public void DeleteRecord(Car car)
        {
            entities.Cars.Remove(car);
            entities.SaveChanges();
        }

        public Car FindCar(string VIN)
        {
            return entities.Cars.Find(VIN); 
        }

        public ICollection<Car> GetAllCars()
        {
            return entities.Cars.ToList();
        }

        public ICollection<Car> GetAllRecords()
        {
            return entities.Cars.ToList();
        }

        public void UpdateRecord(string VIN, Car car)
        {
            var carToUpdate = entities.Cars.Find(VIN);
            carToUpdate.Make = car.Make;
            carToUpdate.Model = car.Model;
            carToUpdate.Year = car.Year;
            carToUpdate.Price = car.Price;
            entities.SaveChanges();
        }
    }

}
