using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            Catalogue catalogue = new Catalogue(cars, trucks);

            while (input[0] != "End")
            {
                if (input[0] == "car")
                {
                    Car car = new Car(input[1], input[2], Convert.ToInt32(input[3]));
                    catalogue.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(input[1], input[2], Convert.ToInt32(input[3]));
                    catalogue.Trucks.Add(truck);
                }
                input = Console.ReadLine().Trim().Split();
            }

            string[] inputSecond = Console.ReadLine().Trim().Split();

            while (inputSecond[0] != "Close")
            {
                foreach (Car car in catalogue.Cars)
                {
                    if (car.Model == inputSecond[0])
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }
                foreach (Truck truck in catalogue.Trucks)
                {
                    if (truck.Model == inputSecond[0])
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }
                inputSecond = Console.ReadLine().Trim().Split();
            }
            double averageCars = 0;
            double averageTrucks = 0;

            foreach (Car car in catalogue.Cars)
            {
                averageCars += car.HorsePower;
            }
            foreach (Truck truck in catalogue.Trucks)
            {
                averageTrucks += truck.HorsePower;
            }
            if (averageCars > 0 && averageTrucks > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCars / catalogue.Cars.Count:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucks / catalogue.Trucks.Count:f2}.");
            }
            else if (averageCars > 0 && averageTrucks <= 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCars / catalogue.Cars.Count:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else if (averageCars <= 0 && averageTrucks > 0)
            { 
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucks / catalogue.Trucks.Count:f2}.");
            }
        }
    }
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Car(string model, string color, int power)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = power;
        }
    }
    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Truck(string model, string color, int power)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = power;
        }
    }
    class Catalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalogue(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }
    }
}
