using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Family
{

	private List<Person> people;
	private List<Person> aboveThirty;

	public Family()
	{
		people = new List<Person>();
		aboveThirty = new List<Person>();
	}

	public void AddMember(Person member)
	{
		if (!people.Contains(member))
		{
			people.Add(member);
			if (member.Age > 30)
			{
				aboveThirty.Add(member);
			}
		}
	}
	public Person GetOldestMember()
	{
		return people.OrderByDescending(a => a.Age).First();
	}
	public List<Person> OverThirty()
	{
		return aboveThirty = aboveThirty.OrderBy(a => a.Name).ToList();
	}
}

