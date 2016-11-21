using UnityEngine;
using System.Collections;

public class InherDog : Inheritance {

	public override void Start()
	{
		base.Start ();
		Bark ();
	}

	void Bark()
	{
		print ("Bark!");
	}

}
