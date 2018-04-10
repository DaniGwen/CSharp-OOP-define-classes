using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
	public string Name { get; set; }
	public double Salary { get; set; }
	public string Position { get; set; }
	public string Department { get; set; }
	public string Email { get; set; }
	public int Age { get; set; }

	public Employee()
	{
		Email = "N/A";
		Age = -1;
	}

	public Employee(string Email, int Age) : this()
	{
		this.Email = Email;
		this.Age = Age;
	}
}

