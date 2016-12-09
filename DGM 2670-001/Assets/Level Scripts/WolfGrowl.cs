using UnityEngine;
using System.Collections;

public class WolfGrowl : MonoBehaviour {

	public AudioClip wolfSound;
	private AudioSource source;
	public float vollow = 0.01f;
	public float volhigh = 1f;

	void PlayOnAwake () 
	{
		source = GetComponent<AudioSource> ();
	}
		
}
