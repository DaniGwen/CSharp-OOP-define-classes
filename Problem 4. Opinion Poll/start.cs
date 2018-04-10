using System;
using System.Collections.Generic;
using System.Linq;
class start
{
	static void Main()
	{
		var people = new HashSet<Person>();
		var n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			var arguments = Console.ReadLine().Split();
			var person = (new Person(arguments[0], int.Parse(arguments[1])));

			if (person.OlderThanThirty(person.Age))
			{
				people.Add(person);
			}
		}
		Console.WriteLine(string.Join(Environment.NewLine, people
			.Where(p => p.Age > 30)
			.OrderBy(p => p.Name)
			.Select(p => $"{p.Name} - {p.Age}")));
	}
}