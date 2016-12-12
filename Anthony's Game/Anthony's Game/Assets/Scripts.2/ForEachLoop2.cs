using UnityEngine;
using System.Collections;

public class ForEachLoop2 : MonoBehaviour 
{

	public string[] powerUps = { "Ruby", "Health Power up", "Garnet", "Gem" };

	void Start () 
	{
		foreach (string _powerUp in powerUps)
		{
			print("I found a" + _powerUp + " !");
		}

	}

}
