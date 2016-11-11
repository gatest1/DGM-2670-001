using UnityEngine;
using System.Collections;

public class WolfJump : MonoBehaviour {

	public float speed = 1;
	private Vector3 tempPos;
	public float thrust = 15;
	public Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update()
	{
		tempPos.x = speed * Time.deltaTime;
		transform.Translate(tempPos);

	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Gap")
			rb.AddForce (thrust, 0, 0, ForceMode.Impulse);
		print ("Cliff Jumper!");

	}
}
