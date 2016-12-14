using UnityEngine;
using System.Collections;

public class CharacterSlide : MonoBehaviour
{
	private CharacterController myCC;
	public int slideDuration = 5;
	public float slideTime = 0.01f;

	IEnumerator Slide()
	{
		int i = 0;
		while (i < slideDuration) 
		{
			i++;
			yield return new WaitForSeconds (slideTime);
			print ("sliding");
		}
	}

	void Start()
	{
		myCC = GetComponent<CharacterController> ();
		StartCoroutine(Slide());
	}



}
