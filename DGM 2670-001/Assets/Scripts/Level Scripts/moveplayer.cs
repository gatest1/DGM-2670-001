using UnityEngine;
using System.Collections;

public class moveplayer : MonoBehaviour {

    public float speed = 10;
    //Use to move the player
    private CharacterController controller;
    //Use to assign location as a temp var
    private Vector3 tempPosition;
    public float gravity = -9.81f;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //Fake gravity
        tempPosition.y = gravity;
        //Using Axis as an input with speed the character can hold or ove left or right.
        tempPosition.x = speed*Input.GetAxis("Horizontal");
        tempPosition *= Time.deltaTime;
        //Move method take the temp vector3 to move.
        controller.Move(tempPosition);
	}
}
