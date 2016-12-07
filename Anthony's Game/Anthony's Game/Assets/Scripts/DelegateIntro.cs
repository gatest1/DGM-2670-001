/*using UnityEngine;
using System;

public class DelegateIntro : MonoBehaviour {
	
	public static Action MyEvent;
	public static Action<string> EventWithArgs;
	public static Func<string> EventString;

	public delegate string DelReturnArgs(string s);
	public static DelReturnArgs EventReturnArgs;

	void Start ()
	{

		string data = EventReturnArgs ("CATS!");

		print (data);

		print (EventString ());

		EventWithArgs ("Hello World!");

		if(MyEvent != null)
			MyEvent ();
	}
}*/