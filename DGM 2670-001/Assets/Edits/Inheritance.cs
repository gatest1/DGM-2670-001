using UnityEngine;
using System.Collections;

public class Inheritance : MonoBehaviour {

	public virtual void Start ()
	{
		
		Walk ();
	}
	
	void Walk()
	{
		print ("Walking");
	}
}
