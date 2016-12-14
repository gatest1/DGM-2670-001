using UnityEngine;
using System.Collections;
using System;

public class Wizards : IComparable<Wizards>
{
	public string name;
	public int pet;

	public Wizards(string newName, int newPet)
	{
		name = newName;
		pet = newPet; 
	}

	public int CompareTo(Wizards other)
	{
		if (other == null)
		{
			return 1;
		}

		return pet = other.pet;
	}

}
