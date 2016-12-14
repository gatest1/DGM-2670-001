using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Blacksmith : MonoBehaviour
{
	void Start()
	{
		Weapons myWeapons = new Weapons();

		myWeapons.Arrow();
		myWeapons.Sword ();
		myWeapons.Axe ();

		Swords mySwords = new Swords();
		mySwords.Block ();
		mySwords.Counter ();
		mySwords.Attack ();
	}
}
