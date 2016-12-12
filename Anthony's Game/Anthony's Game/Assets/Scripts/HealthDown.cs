using UnityEngine;
using System.Collections;

public class HealthDown : MonoBehaviour 
{

	public float healthDown;
	public GameObject player;

	public void Damage ()
	{
		StaticVar.maxHealth = StaticVar.maxHealth - healthDown;
		print (StaticVar.maxHealth);

		if (StaticVar.maxHealth < 0) 
		{
			StaticVar.maxHealth = StaticVar.minHealth;
			print (StaticVar.minHealth);
		}
	}

	public void OnTriggerEnter(Collider player)
	{
		Damage();
	}
}
