using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("How many vechicles would you like to input?");

			int.TryParse(Console.ReadLine(), out int numOfCars);
			List<Car> carsList = new List<Car>(numOfCars);
		
				for (int i = 0; i < numOfCars; i++)
				{
					string make = "un-defined";
					string model = "un-defined";
					int year = 1786;
					double price = 101.4008;

					Console.WriteLine("Please input some information for the vehicle");
					Console.WriteLine("Make");
					make = Console.ReadLine();
					Console.WriteLine("Model");
					model = Console.ReadLine();
					Console.WriteLine("Year");
					int.TryParse(Console.ReadLine(), out year);
					Console.WriteLine("Price");
					double.TryParse(Console.ReadLine(), out price);
					carsList.Add(new Car(make, model, year, price));
				}

			foreach (Car c in carsList)
			{
				c.PrintInfo();
			}
			
		}
	}
}
