using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour 
{

	public bool playOnAwake;

	void Awake ()
	{
		DontDestroyOnLoad(transform.gameObject);
	}
}
