using UnityEngine;
using System.Collections;

public class SwitchStatement2 : MonoBehaviour 
{

	public int weapon = 0;

	void Update ()
	{
		weapon = Random.Range (1,5);
		switch(weapon)
		{
		case 1:
			Debug.Log("The volcano is erupting!");
				break;
		case 2:
			Debug.Log("Getting hot in here!!");
				break;
		case 3:
			Debug.Log ("Watch out for rocks!");
				break;
		case 4:
			Debug.Log ("Are those Rubies?");
				break;
		default:
			Debug.Log("I gotta get out!");
				break;
		}
	}
}
