using UnityEngine;
using System.Collections;

public class ForLoop1 : MonoBehaviour {

	public string[] lava = { "I am", "Rubies are", "Rocks are falling", "It is hot"};

	void Start() {

		for (int i = 0; i < lava.Length; i++)
		{
			print(lava[i] + "inside a volcano!");
		}

		print("I am inside a volcano!");
		print("Rubies are inside a volcano!");
		print("Rocks are falling inside a volcano!");
		print("It is hot inside a volcaon!");

	}
}
