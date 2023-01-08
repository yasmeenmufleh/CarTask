using System;
using System.Collections.Generic;
using System.IO;

namespace CarTask
{
    public class CarServices
    {
        
            private readonly List<Car> _cars = new List<Car>();

            /*
        Loads cars data from "autos.csv" file and store in memory. If cars data is already loaded, 
        then this method should not do anything.
        */
        public void LoadCarsData()
            {
                if (_cars == null)
                {
                    return;
                }


                string[] lines = File.ReadAllLines(@"C:\Users\USER\Downloads\autos (3).csv");
                for (var index = 1; index < lines.Length; index++)
                {
                    var line = lines[index];
                    string[] parts = line.Split(',');

                    var car = new Car();

                    car.Make = parts[0].ToLower();

                    car.NumberOfDoors = parts[1].ToLower();
                    car.BodyStyle = parts[2];
                    car.EngineLocation = parts[3];
                    car.NumberOfCylinders = parts[4].ToLower();
                    if (!string.IsNullOrEmpty(parts[5]))
                        car.HorsePower = Int32.Parse(parts[5]); /*.Length == 0 ? 0 :int.Parse(parts[5])*/ ;

                    if (!string.IsNullOrEmpty(parts[6]))
                        car.Price = Convert.ToInt32(parts[6]);

                    _cars.Add(car);
                }
                for (var i = 0; i < _cars.Count; i++) 
                {
                 Console.WriteLine(_cars[i]);
                }
            }

        /*
    Filters the loaded cars data using the provided filter and returns a list of cars.
    You should implement Car and CarFilter classes. The caller of this method should be able 
    to filter cars based on their make, hourse power range, price range, number of doors and number of cylinders.
    */
        public List<Car> Filter(CarFilter filter)
        {
            var filteredCars = new List<Car>();
            foreach (var car in _cars)
            {
                if (filter.Make != null && car.Make.ToLower() != filter.Make.ToLower())
                {
                    continue;
                }
                if (filter.MinHorsePower != null && car.HorsePower < filter.MinHorsePower)
                {
                    continue;
                }
                if (filter.MaxHorsePower != null && car.HorsePower > filter.MaxHorsePower)
                {
                    continue;
                }
                if (filter.MinPrice != null && car.Price < filter.MinPrice)
                {
                    continue;
                }
                if (filter.MaxPrice != null && car.Price > filter.MaxPrice)
                {
                    continue;
                }
                if (filter.NumberOfDoors != null && car.NumberOfDoors.ToLower() != filter.NumberOfDoors.ToLower())
                {
                    continue;
                }
                if (filter.NumberOfCylinders != null && car.NumberOfCylinders.ToLower() != filter.NumberOfCylinders.ToLower())
                {
                    continue;
                }
                filteredCars.Add(car);
            }
            return filteredCars;
        }


    }
}


