using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

    //This is the Character Controller Component
    public CharacterController myCC;
    //Temp var of datatype Vector3 to move the character
    private Vector3 tempPos;
    //Speed of the temp var in x
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;

    public int jumpCount = 0;
    public int jumpCountMax = 2;
    //Sliding vars
    public int slideDuration = 100;
    public float slideTime = 0.01f;
    //Coroutine for Sliding the Character
    IEnumerator Slide ()
    {
        //Set a temp var to the value of slideDuration
        int durationTemp = slideDuration;
        //
        float speedTemp = speed;
        speed += speed;
        //While loop runs "while" the slideDuration is greater than 0
        while (slideDuration > 0)
        {
            //Decrement slideDuration
            slideDuration--;
            //yield "holds the coroutine"
            //return "sends" to the coroutine to do an operation while yielding
            //New creates an instance of an object
            //WaitForSeconds is an object that waits for a duration of time
            yield return new WaitForSeconds(slideTime);
            
        }
        speed = speedTemp;
        slideDuration = durationTemp;
    }

    // Update is called once per frame
    void Update () {
        //Waiting for input and comparing jumpcount
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax-1)
        {
            //incrementing the jumpcount by 1
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }
        //Start Sliding
        if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //Start Coroutine is a function that calls a coroutine.  Use the coroutine in the argument
            StartCoroutine(Slide());
        }

        //test if the Charactercontroller is gounded
        if (myCC.isGrounded)
        {
            //reset the jump count if grounded
            jumpCount = 0;
        }
        //adding the gravity bar to the y positionof the tempPos var
        tempPos.y -= gravity;
        //adding the speed var to the tempPos var x value with the right and left arrow keys
        tempPos.x = speed * Input.GetAxis("Horizontal");
        //Moves the Character Controller in at an even pace (deltaTime)
        myCC.Move(tempPos * Time.deltaTime);  
		{
			if(gameObject.tag == "PickUp")
			{
				gameObject.SetActive(false);
			}

		}
	}

}
