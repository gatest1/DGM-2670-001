using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	void OnTriggerEnter () 
	{
		SceneManager.LoadScene(3);
	}

	void Start ()
	{
		StaticVars.nextSectionPosition = StaticVars.startPos;
	}
}
