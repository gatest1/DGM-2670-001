using UnityEngine;
using System.Collections;
using System;

public class UpdateAndDelegates : MonoBehaviour {



    //Actions are a type of delegate.  Delegates contain Functions just as Vars contain Data.
    Action DisplayHealth;
    Action KillThePlayer;
    Action EndTheGame;

    int health = 250;

    // Use this for initialization
    void Start() {
        //We assign function DisplayHealthHandler to the actin DisplayHealth
        DisplayHealth = DisplayHealthHandler; }

    void DisplayHealthHandler()
    {
        print("Health is good.");
        //We unassign all functions from DisplayHealth
        DisplayHealth = null;
        KillThePlayer = KillThePlayerHandler;
    }



    void EndTheGameHandler ()
    {
        print("You Died.  You didn't even try.  Looser...");
        EndTheGame = null;
    }

    void KillThePlayerHandler ()
    {
        health--;
        print(health);
        if (health < 0)
        {
            KillThePlayer = null;
            EndTheGame = EndTheGameHandler;
        }
    }

    
	
	// Update is called once per frame
	void Update () {
        //We check if  any function is assigned to DisplayHealth
        //If nothing is assigned DisplayHealth will not run
        if(DisplayHealth != null)
        DisplayHealth();

        if (KillThePlayer != null)
            KillThePlayer();

        if (EndTheGame != null)
            EndTheGame();
	}
}
