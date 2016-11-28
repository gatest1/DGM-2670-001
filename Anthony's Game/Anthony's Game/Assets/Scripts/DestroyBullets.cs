using UnityEngine;
using System.Collections;

public class DestroyBullets : MonoBehaviour 
{
	public GameObject hero;
	public float heroTargetDistance;
	public float bulletSpeed;
	public Transform heroTarget;
	public float enemyShootDistance;
	public float damping;
	private int aimAtPlayer;
	private int i;
	Rigidbody theRigidbody;
	Renderer myRender;

	void Start () 
	{
		myRender = GetComponent<Renderer>();
		theRigidbody = GetComponent<Rigidbody> ();
		aimAtPlayer = 10;
		i = 0;
	}
		
	void Update ()
	{
		heroTargetDistance = Vector3.Distance (heroTarget.position, transform.position);
		if (heroTargetDistance < enemyShootDistance && i < aimAtPlayer) 
		{
			AimAtPlayer ();
			aimAtPlayer--;
			print ("Aim!");
		}
		if (heroTargetDistance < enemyShootDistance) 
		{
			shootPlayer ();
			print ("Fire!");
		}
	}

	void OnCollisionEnter(Collision col)
		{
		if(col.gameObject == hero)
			{
				Destroy(gameObject);
			print ("I've been shot!");
			}
		}

	void AimAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (heroTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}
	void shootPlayer ()
		{
			theRigidbody.AddForce (transform.forward*bulletSpeed);
		}

}

