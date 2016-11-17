using UnityEngine;
using System.Collections;

public class JumpCaller : MonoBehaviour {

	public WolfMovement Script;

	void OnTriggerEnter ()
	{
		Script.jump ();
		print ("WORK ALREADY!");

	}
}
