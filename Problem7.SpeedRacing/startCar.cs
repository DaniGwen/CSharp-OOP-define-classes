using System;
using System.Collections.Generic;


class startCar
{
	static void Main()
	{
		HashSet<Car> cars = new HashSet<Car>();
		cars = GetCars();
		string input;
		while ((input = Console.ReadLine()) != "End")
		{
			var args = input.Split();
			string model = args[1];
			var distance = int.Parse(args[2]);

			foreach (var car in cars)
			{
				if (car.model == model)
				{
					car.Drive_Car(distance);
				}
			}
		}
	}

	public static HashSet<Car> GetCars()
	{
		int numOfCars = int.Parse(Console.ReadLine());
		var listCars = new HashSet<Car>();
		while (numOfCars > 0)
		{
			var arguments = Console.ReadLine().Split();
			var car = (new Car(double.Parse(arguments[2]), Double.Parse(arguments[1]), arguments[0]));
			listCars.Add(car);
			numOfCars--;
		}
		return listCars;
	}
}


