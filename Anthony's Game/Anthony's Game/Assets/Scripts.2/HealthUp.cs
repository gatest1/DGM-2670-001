using UnityEngine;
using System.Collections;

public class HealthUp : MonoBehaviour 
{

	public float healthUp;
	public GameObject player;

	public void OnTriggerEnter (Collider player)
	{
		StaticVar.maxHealth = StaticVar.maxHealth + healthUp;
		print (StaticVar.maxHealth);

		if (StaticVar.maxHealth > 10) 
		{
			StaticVar.maxHealth = 10;
		}
	}
}
