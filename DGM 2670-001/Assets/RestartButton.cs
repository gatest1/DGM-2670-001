using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour {

	public void TaskOnClick ()
	{
		SceneManager.LoadScene (2);
	}
}
