using UnityEngine;
using System.Collections;

public class CloneTumbleweed : MonoBehaviour {



	public Transform[] spawnPoint;
	public Transform tumbleweed;
	public float spawnFrequency = 1;
	public bool canSpawnTumbleweed = true;

	private int i = 0;

	IEnumerator SpawnTumbleweed ()
	{

		while (canSpawnTumbleweed) 
		{
			i = Random.Range (0, spawnPoint.Length - 1);
			print (spawnPoint.Length);
			Instantiate (tumbleweed, spawnPoint [i].position, Quaternion.identity);
			yield return new WaitForSeconds(spawnFrequency);

		}

	}

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnTumbleweed ());
	}
}
