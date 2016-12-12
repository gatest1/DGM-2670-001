using UnityEngine;
using System.Collections;

public class WhileLoop2: MonoBehaviour 
{
	int rubiesfalling = 50;

	void Start ()
	{
		while (rubiesfalling > 0) 
		{
			Debug.Log ("I'm catching rubies!");
			rubiesfalling--;
		}
	}

}
