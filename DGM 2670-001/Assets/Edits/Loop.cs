using UnityEngine;
using System.Collections;

public class Loop : MonoBehaviour {

	private int timeLimit = 0;

	void CountDown ()
	{
		for (int i = 0; i < 5; i++) {
			timeLimit = Random.Range (1, 60);

			if (timeLimit >= 30) {
				Debug.Log ("You'd better hurry!");
			}
			if (timeLimit >= 1 && timeLimit <= 15) {
				Debug.Log ("You're running out of time!");
			}
		}
		if (timeLimit < 1) {
			Debug.Log ("It's all over!");
		}
	}
}