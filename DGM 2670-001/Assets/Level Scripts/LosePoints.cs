using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LosePoints : MonoBehaviour 
{
	public Text Score;

	void OnTriggerEnter()
	{
		StaticCount.count -= 1;
		print ("Damage");
		Score.text = "Score: " + StaticCount.count.ToString ();
		
	}



}
