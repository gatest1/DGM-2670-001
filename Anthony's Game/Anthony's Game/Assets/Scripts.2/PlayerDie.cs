using UnityEngine;
using System.Collections;

public class PlayerDie : MonoBehaviour, ICanDie, IHurt, ITakeDamage
{
	public void CanDie () 
	{
		print ("I'm Dying!");
	}

	public void Hurt ()
	{
		print("OUCH! THAT HURT!");
	}

	public void TakeDamage () 
	{
		print ("I'd better be careful!");
	}
}
