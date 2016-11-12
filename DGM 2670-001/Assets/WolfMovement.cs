using UnityEngine;
using System.Collections;

public class WolfMovement : MonoBehaviour 
{
	public GameObject player;
	public Vector3 tempPos;
	public Transform wolf;
	public CharacterController character;

	public bool canFlipWolf = true;

	public float speed = 5;
	public float gravity = 10;
	public float jumpPower = 5;

	void WolfFlipper () {
		if (player.transform.position.x < wolf.transform.position.x && canFlipWolf) 
		{
			wolf.Rotate (0, -180, 0);
			canFlipWolf = false;
			tempPos.x = -speed;
		}
		if (player.transform.position.x > wolf.transform.position.x && !canFlipWolf) 
		{
			wolf.Rotate (0, 180, 0);
			canFlipWolf = true;
			tempPos.x = speed;
		}
	}

	IEnumerator WolfMover()
	{
		while (true) 
		{
			//if (player.transform.position.x > transform.position.x) {
			//	tempPos.x = speed;
			//} 
			//else 
			//{
			//	tempPos.x = -speed;
		//	}
			tempPos.y -= gravity;
			character.Move (tempPos * Time.deltaTime);
			//transform.position = Vector3.MoveTowards (transform.position, new Vector3 (player.transform.position.x, transform.position.y, transform.position.z), speed * Time.deltaTime);
			yield return new WaitForSeconds (.02f);
			//StartCoroutine (WolfMover ());
			WolfFlipper ();
		}
	}

	//void OnTriggerEnter (Collider Gap)
	//{
	//	if (Gap.gameObject.tag == "Gap")
	//	{tempPos.y = jumpPower;
		//rigidbody.AddForce (jump, 0, 0, ForceMode.Impulse);
	//		print ("Cliff Jumper!");}
//	}

	void Start ()
	{
		tempPos.x = speed;
		StartCoroutine (WolfMover ());
	}

	public void jump ()
	{
		tempPos.y = jumpPower;
	}
}