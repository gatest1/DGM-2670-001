using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour 
{

	public CharacterController myCC;
	private Vector3 tempPos;
	public float speed = 1;
	public float gravity = 1;
	public float jumpSpeed = 1;
	public int jumpCount = 0;
	public int jumpCountMax = 2;


	void Start ()
	{
		myCC = GetComponent<CharacterController> ();
	}


	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax-1)
			{
			jumpCount++;

			tempPos.y = jumpSpeed;
			}
		if (myCC.isGrounded)
			{
			jumpCount = 0;
			}
		tempPos.y -= gravity;
		tempPos.x = speed * Input.GetAxis("Horizontal");
		myCC.Move(tempPos * Time.deltaTime); 
			{
			if(gameObject.tag == "PickUp")
				{
				gameObject.SetActive(false);
				}
			}
	}
}
