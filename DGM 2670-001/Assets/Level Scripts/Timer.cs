using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text timerText;
	//public float myTimer = 107;
	private bool gameOver = false;
	public Text gameOverText;
	private bool timerIsActive = true;

	void Start ()
	{
	//	timerText = GetComponent<Text> ();
	}

	void Update ()

	{
		timerText.text = "Time Left: " + Mathf.Round (StaticVars.gameTime -= Time.deltaTime);
		gameOverText.text = "";

	if (timerIsActive)
	{
			
	//	myTimer -= Time.deltaTime;
	//	timerText.text = "Time Left: " + myTimer.ToString ("f0");
			if (StaticVars.gameTime < 0)
		{
			StaticVars.gameTime = 0;
			timerIsActive = false;
			GameOver ();
		}
	}

}

	public void GameOver ()
{
	gameOverText.text = "Game Over!";
	gameOver = true;

	SceneManager.LoadScene (0);
}

}
