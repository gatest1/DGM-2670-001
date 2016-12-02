using UnityEngine;
using System.Collections;

public class EventHAndlerIntro : MonoBehaviour 
{

	void Start () 
	{
		DelegateIntro.MyEvent += MyEventHandler;
		DelegateIntro.EventWithArgs += EventWithArgsHandler;
		DelegateIntro.EventString += EventStringHandler;
		DelegateIntro.EventReturnArgs += EventReturnArgsHandler;
	}

	private void EventReturnArgsHandler(string s)
	{
		return "The animals I hate most are " + s;
	}

	private void EventStringHandler()
	{
		print ("Do you hate cats?");
		return "I hate cats!";
	}

	private void EventWithArgsHandler(string s)
	{
		print(s);
	}

	private void MyEventHandler()
	{
		print ("Ran");
	}

}