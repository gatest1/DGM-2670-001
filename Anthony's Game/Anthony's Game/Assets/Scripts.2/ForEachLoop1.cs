using UnityEngine;
using System.Collections;

public class ForEachLoop1 : MonoBehaviour 
{

	public string[] pickUps = { "Ring", "Flower", "Rock", "Coin" };

	void Start () {
		foreach (string _pickUp in pickUps)
		{
			print("I found a pretty" + _pickUp + " on my way home from school.");
		}

	}
		
}
