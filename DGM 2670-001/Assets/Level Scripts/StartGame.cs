using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void loadLevel()
	{
		StaticVars.gameTime = 67f;
		SceneManager.LoadScene (2);
	}
}
