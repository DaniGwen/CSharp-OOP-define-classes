using System;
using System.Collections.Generic;
using System.Text;


public class DateModifier
{

	public DateModifier(string inputOne, string inputTwo)
	{
		DateTime data1 = DateTime.Parse(inputOne);
		DateTime data2 = DateTime.Parse(inputTwo);

		TimeSpan difference = data1 - data2;

		Console.WriteLine(Math.Abs(difference.Days));
	}

}
