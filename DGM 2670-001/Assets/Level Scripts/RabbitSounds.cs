using UnityEngine;
using System.Collections;

public class RabbitSounds : MonoBehaviour {

	public AudioClip bonk;
	private AudioSource source;
	public float vollow = 0.01f;
	public float volhigh = 1f;

	void Awake () 
	{
		source = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter (Collision col) 
	{
		if (col.gameObject.tag == "Wolf") 
		{
			float vol = Random.Range (vollow, volhigh);
			source.PlayOneShot (bonk, vol);
		}
	}
}
