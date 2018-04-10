using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
	//GET SET age and name
	private int age;
	private string name;
	private int Age
	{
		get { return age; }
		set { age = value; }
	}
	private string Name
	{
		get { return name; }
		set { name = value; }
	}
	public Person()
	{
		name = "No name";
		age = 1;
	}
	public Person(int age) : this()
	{
		this.age = age;
	}
	public Person(string name, int age) : this(age)
	{
		this.name = name;
		this.age = age;
	}
	
}

