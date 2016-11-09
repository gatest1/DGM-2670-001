using UnityEngine;
using System.Collections;

public class IfStatementSwitchStatements : MonoBehaviour {

	public float jump = 0.0f;
	public float distance = 210.0f;
	public float time = 3.0f;
	public float maxJumpLimit = 20.0f;
	public float minJumpLimit = 20.0f;

	void Start()
	{
	}
	void Update ()
	{
		jump = distance / time;
		if (jump > maxJumpLimit)
		{
			Debug.Log("You're jumping too high!");
		}
		else if(jump < minJumpLimit)
		{
			Debug.Log("That's a whimpy jump...");
		}
		else if(jump == maxJumpLimit || jump == minJumpLimit)
		{
			Debug.Log("Wow, that's a huge jump!");
		}
		else
		{
			Debug.Log("That's a pretty good jump!");
		}
	}

}
