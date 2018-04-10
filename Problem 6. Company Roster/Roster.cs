using System;
using System.Collections.Generic;
using System.Linq;

public class Roster
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		var employeeList = new List<Employee>();

		for (int i = 0; i < n; i++)
		{
			var args = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var employee = GetEmployee(args);
			employeeList.Add(employee);
		}
		var result = employeeList
			.GroupBy(a => a.Department)
			.Select(e => new { department = e.Key, averageSalary = e.Average(av => av.Salary), Employees = e.OrderByDescending(emp => emp.Salary) })
			.FirstOrDefault();

		Console.WriteLine($"Highest Average Salary: {result.department}");

		foreach (var employee in result.Employees)
		{
			Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
		}


	}

	public static Employee GetEmployee(string[] args)
	{
		var employee = new Employee();
		employee.Name = args[0];
		employee.Salary = double.Parse(args[1]);
		employee.Position = args[2];
		employee.Department = args[3];
		if (args.Length > 4)
		{
			if (!args[4].Contains("@"))
			{
				employee.Age = int.Parse(args[4]);
			}
			else if (args[4].Contains("@"))
			{
				employee.Email = args[4];
			}
			if (args.Length > 5)
			{
				employee.Age = int.Parse(args[5]);
			}
		}
		return employee;
	}
}

