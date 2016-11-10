using UnityEngine;
using System.Collections;
using System;

public class DelegatesGeneral : MonoBehaviour {

	Action<DelegatesGeneral> Move;
	Action Idle;
	Action Jump;

	int speed = 200;

	void MoveHandler (DelegatesGeneral _obj)
	{
		print ("Moving at" + _obj.speed + "mph.");
		Move = null;
		Idle = IdleHandler;
	}

	void IdleHandler ()
	{
		print ("Idling");
		Idle = null;
		Jump = JumpHandler;
	}

	void JumpHandler ()
	{
		print ("Jumping");
		Jump = null;
	}

	void Start ()
	{
		Move = MoveHandler;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Move != null)
		Move (this);
		
		if (Idle != null)
		Idle ();
		
		if (Jump != null)
		Jump ();
	}
}
