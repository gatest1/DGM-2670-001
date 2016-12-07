﻿using UnityEngine;
using System.Collections;

public class CloneRubble : MonoBehaviour {


	public Transform[] spawnPoints;
	public Transform rubble;
	public float spawnFrequency = 1;
	public bool canSpawnRubble = true;

	private int i = 0;

	IEnumerator SpawnRubble ()
	{

		while (canSpawnRubble) 
		{
			i = Random.Range (0, spawnPoints.Length - 1);
			print (spawnPoints.Length);
			Instantiate (rubble, spawnPoints [i].position, Quaternion.identity);
			yield return new WaitForSeconds(spawnFrequency);

		}

	}

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnRubble ());
	}

}
