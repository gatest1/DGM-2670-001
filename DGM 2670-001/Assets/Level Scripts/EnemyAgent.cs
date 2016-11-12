using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	public NavMeshAgent myAgent;
	public Transform player;
	public Animation myAnims;

	// Use this for initialization
	void Start () {
		myAgent = GetComponent<NavMeshAgent> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		myAgent.destination = player.position;

		if (!myAgent.isOnOffMeshLink) 
		{
//			myAnims.SetBool ("jump", true);
		}
	}
}
