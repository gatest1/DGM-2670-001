using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void loadLevel()
	{
		StaticVars.gameTime = 64f;
		MusicScript.PlayMusic ();
		SceneManager.LoadScene (2);
	}
}
