using System;
using System.Collections;
using System.Collections.Generic;

static class ArraysAndLists 
{

	static void Main ()
	{
		int[] ints = new int[] {1,5,10};
		ArrayList myStarValues = new ArrayList();
		myStarValues.Add (1);
		myStarValues.Add (5);
		myStarValues.Add (10);
		foreach(int value in myStarValues)
			Console.WriteLine(value);
	}
}

