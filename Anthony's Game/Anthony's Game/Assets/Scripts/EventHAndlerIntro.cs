using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class EventHAndlerIntro : MonoBehaviour 
{

	void Start () 
	{
		DelegateIntro.MyEvent += MyEventHandler;
		DelegateIntro.WithArgs += WithArgsHandler;
		DelegateIntro.EventString += EventStringHandler;
	}
		
	private void MyEventHandler(string a)
	{
		print (a);
	}
	private void WithArgsHandler(string s)
	{
		print("The animals I hate most are " + s);
	}

	private void EventStringHandler(string s)
	{
		print(s);
	}


		

}