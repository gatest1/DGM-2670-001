using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void loadLevel()
	{
		StaticVars.gameTime = 65f;
		SceneManager.LoadScene (2);
	}
}
