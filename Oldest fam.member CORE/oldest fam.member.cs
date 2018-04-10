using System;
using System.Collections.Generic;



class Program
{
	static void Main(string[] args)
	{

		int count = int.Parse(Console.ReadLine());
		Family family = new Family();


		for (int i = 0; i < count; i++)
		{
			var data = Console.ReadLine().Split();
			string name = data[0];
			int age = (int.Parse(data[1]));

			Person person = new Person(name, age);
			family.AddMember(person);
		}
		var elder = new List<Person>(family.OverThirty());

		foreach (var man in elder)
		{
			Console.WriteLine($"{man.Name} - {man.Age}");
		}

	}
}

