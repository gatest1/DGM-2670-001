using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;

	// Use this for initialization
	void Start () 
	{
		speed = 10f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		transform.Translate (speed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, speed*Input.GetAxis("Vertical")*Time.deltaTime);
	
	}
}
