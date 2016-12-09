using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartLevel : MonoBehaviour {
	

	void OnTriggerEnter () 
	{
		MusicScript.DestroyThis ();
		SceneManager.LoadScene(3);
	}

	void Start ()
	{
		StaticVars.nextSectionPosition = StaticVars.startPos;
	}
}
