using System;
using System.Threading.Channels;

namespace CarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loads cars data from autos.csv file :");
            Console.WriteLine("Make,NumberOfDoors,BodyStyle,EngineLocation,NumberOfCylinders,HorsePower,Price");
            var carService = new CarServices();
                carService.LoadCarsData();
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("Here is the filter that returns a list of cars :");
                var filter = new CarFilter
                {   //audi,four,sedan,front,five,115,17450

                    //Make = "Audi",
                    MinHorsePower = 100,
                    MaxHorsePower = 150,
                    MinPrice = 10000,
                    MaxPrice = 20000,
                    NumberOfDoors = "FOUR",
                    NumberOfCylinders = "five"
                };
            var filteredCars = carService.Filter(filter);
            foreach (var car in filteredCars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();


        }
    }
}
