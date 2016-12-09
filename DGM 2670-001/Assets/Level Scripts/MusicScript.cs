using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour 
{
	private static MusicScript _instance;
	private static AudioSource thisObject;

	void Start ()
	{
		print ("The hills are alive with the sound of MUSIC!");
		thisObject = GetComponent <AudioSource> ();


		if (!_instance) 
		{
			_instance = this;
		}
		else
			Destroy (this.gameObject);
			DontDestroyOnLoad(transform.gameObject);
	}

	void Update ()
	{
		thisObject = GetComponent <AudioSource> ();
	}

	public static void DestroyThis ()
	{
		thisObject.Stop ();
	}

	public static void PlayMusic ()
	{
		thisObject.Play ();
	}
}
