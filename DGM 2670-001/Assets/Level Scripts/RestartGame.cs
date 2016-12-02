using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class RestartGame : MonoBehaviour {

	void OnTriggerEnter () 
	{
       SceneManager.LoadScene(2);
	}

	void Start ()
	{
		StaticVars.nextSectionPosition = StaticVars.startPos;
	}
}
