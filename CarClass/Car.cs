using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
	class Car
	{
		public string make = "un-defined";
		public string model = "un-defined";
		public int year = 1786;
		public double price = 19.99;

		public Car(string make, string model, int year, double price)
		{
			this.make = make;
			this.model = model;
			this.year = year;
			this.price = price;
		}

		public void PrintInfo()
		{
			Console.WriteLine("\n");
			Console.WriteLine("Vehicle information\n" +
							  "___________________\n" +
							  "Make: " + make  +
							  "\nModel: " + model +
							  "\nYear: " + year +
							  "\nMSRP: " + price );
		}

	}
}