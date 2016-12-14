using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeOtherClass : MonoBehaviour {


	void Start () 
	{
		Dictionary<string, Wizards> wizards = new Dictionary<string, Wizards> ();

		Wizards wiz1 = new Wizards ("Harry", 75);
		Wizards wiz2 = new Wizards ("Dumbledore", 100);

		wizards.Add ("Hedwig", wiz1);
		wizards.Add ("Fawkes", wiz2);

		Wizards harry = wizards ["Headwig"];

		Wizards temp = null;

		if (wizards.TryGetValue ("Pickit", out temp)) {
			print ("This is my pet.");
		} 
		else 
		{
			print ("This is not my pet.");
		}
	}

}
