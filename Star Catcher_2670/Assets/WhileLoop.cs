﻿using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

    string[] screenTitles = {"5", "4", "3", "2", "1", "GO!"};

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


	// Use this for initialization
	void Start () {
        StartCoroutine(GameCountDown());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
