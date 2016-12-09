using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour {

	public void TaskOnClick ()
	{
		StaticVars.gameTime = 64f;
		MusicScript.PlayMusic ();
		SceneManager.LoadScene (2);
	}
}
