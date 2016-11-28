using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddToScore : MonoBehaviour {

	public Text Score;

	// Use this for initialization
	void Start () {
		
		SetCountText ();
	
	}

	void OnTriggerEnter()
	{
		StaticCount.count += 1;
		SetCountText ();
	}
	
	void SetCountText()
	{
		Score.text = "Score: " + StaticCount.count.ToString ();
	}
}
