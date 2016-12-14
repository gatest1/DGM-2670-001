using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeClass : MonoBehaviour {

	void Start ()
	{
		List<Wizards> wizards = new List<Wizards> ();

		wizards.Add( new Wizards("Harry", 75));
		wizards.Add( new Wizards("Dumbledore", 100));
		wizards.Add( new Wizards("Newt", 50));

		wizards.Sort();

		foreach(Wizards wiz in wizards)
		{
			print (wiz.name + " " + wiz.pet);
		}
		
		wizards.Clear();
	}
}
