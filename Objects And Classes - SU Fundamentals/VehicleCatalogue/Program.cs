using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalgoue
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Trim().Split('/');
			Catalogue catalogue = new Catalogue();
			while (input[0] != "end")
			{
				if (input[0] == "Car")
				{
					Car car = new Car();
					car.Brand = input[1];
					car.Model = input[2];
					car.HorsePower = input[3];
					catalogue.Cars.Add(car);
				}
				else
				{
					Truck truck = new Truck();
					truck.Brand = input[1];
					truck.Model = input[2];
					truck.Weight = input[3];
					catalogue.Trucks.Add(truck);
				}
				input = Console.ReadLine().Trim().Split('/');
			}
			catalogue.Cars = catalogue.Cars.OrderBy(x => x.Brand).ToList();
			catalogue.Trucks = catalogue.Trucks.OrderBy(x => x.Brand).ToList();
			if (catalogue.Cars.Count != 0 && catalogue.Trucks.Count != 0)
			{
				Console.WriteLine("Cars:");
				foreach (Car car in catalogue.Cars)
				{
					Console.WriteLine(car.Brand + ": " + car.Model + " - " + car.HorsePower + "hp");
				}
				Console.WriteLine("Trucks:");
				foreach (Truck truck in catalogue.Trucks)
				{
					Console.WriteLine(truck.Brand + ": " + truck.Model + " - " + truck.Weight + "kg");
				}
			}
			else if (catalogue.Cars.Count != 0 && catalogue.Trucks.Count == 0)
			{
				Console.WriteLine("Cars:");
				foreach (Car car in catalogue.Cars)
				{
					Console.WriteLine(car.Brand + ": " + car.Model + " - " + car.HorsePower + "hp");
				}
			}
			else if (catalogue.Cars.Count == 0 && catalogue.Trucks.Count != 0)
			{
				Console.WriteLine("Trucks:");
				foreach (Truck truck in catalogue.Trucks)
				{
					Console.WriteLine(truck.Brand + ": " + truck.Model + " - " + truck.Weight + "kg");
				}
			}
		}
	}
	public class Truck
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Weight { get; set; }
	}
	public class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public string HorsePower { get; set; }
	}
	public class Catalogue
	{
		public List<Car> Cars { get; set; }
		public List<Truck> Trucks { get; set; }
		public Catalogue()
		{
			this.Cars = new List<Car>();
			this.Trucks = new List<Truck>();
		}
	}
}
