using UnityEngine;
using System.Collections;

public class WolfJump : MonoBehaviour {

	public float speed = 1;
	private Vector3 tempPos;
	public float jump = 15;
	//public Rigidbody rigidbody;
	public CharacterController character;

	void Start ()
	{
	//	rigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update()
	{
		tempPos.x = speed * Time.deltaTime;
		character.Move (tempPos * Time.deltaTime);

	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Gap")
			tempPos.y = jump;
			//rigidbody.AddForce (jump, 0, 0, ForceMode.Impulse);
		print ("Cliff Jumper!");

	}
}
