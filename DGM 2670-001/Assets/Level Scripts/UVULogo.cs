using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UVULogo : MonoBehaviour {

	public int WaitTimer = 3;

	void Start () 
	{
		StartCoroutine (LevelChanger ());
	}

	IEnumerator LevelChanger () 
	{
		yield return new WaitForSeconds (WaitTimer);
		SceneManager.LoadScene (1);
	}

	/*void Update ()
	{
		if (Input.GetKey ("escape"))
			Application.Quit ();
	}*/
}
