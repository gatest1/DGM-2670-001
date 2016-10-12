using UnityEngine;
using System.Collections;

public class ForEachLoops : MonoBehaviour {

    public string[] powerUps = { "Health", "Ammo", "Power", "Magic", "Shield" };

	// Use this for initialization
	void Start () {
	foreach (string _powerUp in powerUps)
        {
            print("I found a " + _powerUp + " power-up on the way to grandma's.");
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
