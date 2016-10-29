using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text timerText;
	public float myTimer = 60;
	private bool gameOver = false;
	public Text gameOverText;
	private bool timerIsActive = true;

	void Start ()
	{
		timerText = GetComponent<Text> ();

		gameOverText.text = "";
	}

	void Update ()
	{
	if (timerIsActive)
	{
		myTimer -= Time.deltaTime;
		timerText.text = "Time Left: " + myTimer.ToString ("f0");
		if (myTimer < 0)
		{
			myTimer = 0;
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



	/*pulbic Text timerText;
	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");

		timerText.text = minutes + ":" + seconds;
	}*/
}
