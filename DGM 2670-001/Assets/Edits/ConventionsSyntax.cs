//These are name spaces
using UnityEngine;
using System.Collections;
//This is the specific class
public class ConventionsSyntax : MonoBehaviour
{
    //This is a single line comment.

    //Below is a multiple line comment that can be used for multiple lines

    /*  public string myName = "Taylor";
    public float height = 5.1f;
    public bool isCool = true;
    private int myAge;
    public int health = 100;
    private int maxHealthCount = 100;
    */

//This is a public interger that I've named 'MyFavoriteNumber' which is equal to 11.
//The ; at the end of the line ends the statement.
public int MyFavoriteNumber  = 11;


	// This is the beginning of the Start Function
	void Start ()
    {
        //These curly bracers indicate that this is where the blueprints of the function will go.
        print(MyFavoriteNumber);
	}
	
	// This is the beginning of the Update Function
	void Update ()
    {
        //This is an addition of 1 to my favorite number while the game is playing.
        Debug.Log(MyFavoriteNumber + 1);
	}
}
