using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class DelegateIntro : MonoBehaviour 
{

	public static Action<string> MyEvent;
	public static Action<string> WithArgs;
	public static Action<string>EventString;

	void Start()
	{
		print (MyEvent);
	}

	void OnMouseDown()
	{
		print (WithArgs);
	}

	void OnTriggerEnter()
	{
		print (EventString);
	}		
}