using System;
using System.Collections.Generic;
using System.Text;

class Car
{
	public double FuelConsumption;
	public double FuelAmount;
	public string model;
	public int DistanceTraveled { get; set; }

	public Car(double fuelConsumption, double fuelAmount, string model)
	{
		this.FuelAmount = fuelAmount;
		FuelConsumption = fuelConsumption;
		this.model = model;
		DistanceTraveled = 0;
	}
	public  void Drive_Car(int distance)
	{
		if ((distance * FuelConsumption) < FuelAmount)
		{
			FuelAmount -= distance * FuelConsumption;
			DistanceTraveled += distance;
		}
		else
		{
			Console.WriteLine("Insufficient fuel for the drive");
		}
	}
}

