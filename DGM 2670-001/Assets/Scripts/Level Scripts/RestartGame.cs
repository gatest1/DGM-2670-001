using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartGame : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
        SceneManager.LoadScene(0);

	}

	void Start ()
	{
		StaticVars.nextSectionPosition = StaticVars.startPos;
	}
	
}
