using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour {

	public void TaskOnClick ()
	{
		SceneManager.LoadScene (1);
	}
}
