using UnityEngine;
using System.Collections;

public class ForLoop2 : MonoBehaviour 
{

	public string[] shouts = { "is insane!", "is crazy!", "was a BAD idea!"};

	void Start() {

		for (int i = 0; i < shouts.Length; i++)
		{
			print("This " + shouts[i]);
		}

		print("This is insane!");
		print("This is crazy!");
		print("This was a BAD idea!");

	}
}
