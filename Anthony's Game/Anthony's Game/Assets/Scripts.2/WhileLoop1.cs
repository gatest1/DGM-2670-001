﻿using UnityEngine;
using System.Collections;

public class WhileLoop1 : MonoBehaviour 
{
	
	string[] screenTitles = {"5", "4", "3", "2", "1", "You're Dead!"};

	IEnumerator GameCountDown ()
	{
		int i = 0;

		while (i < screenTitles.Length)
		{
			print(screenTitles[i]);
			yield return new WaitForSeconds(0.5f);
			i++;

		}
	}
		
	void Start () 
	{
		StartCoroutine(GameCountDown());
	}
}
