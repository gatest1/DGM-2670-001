using UnityEngine;
using System.Collections;

public class RubbleControl : MonoBehaviour {

	public float forceDuration = 0.1f;
	private bool canAddForce = true;
	private Rigidbody rigid;
	private float force;
	private Vector3 forceVector;
	public float forceRange = 10;
	private Vector3 torqueVector;

	void Start ()
	{
		rigid = GetComponent<Rigidbody> ();
		StartCoroutine (RunRandomForce());
	}

	IEnumerator RunRandomForce()
	{
		force = Random.Range (-forceRange, forceRange);
		while (canAddForce) 
		{
			yield return new WaitForSeconds (forceDuration);
			forceVector.x = force;
			torqueVector.z -= force * 0.2f;
			rigid.AddTorque (torqueVector);
			rigid.AddForce (forceVector);
		}
	}

	public float endTime = 3;

	void OnCollisionEnter () {
		canAddForce = false;
		Destroy (gameObject, endTime);
	}
}
