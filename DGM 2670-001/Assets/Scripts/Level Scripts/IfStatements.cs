using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

    public bool isDoorUnlocked = false;

    // Use this for initialization
    void Start()
    {
        if (isDoorUnlocked)
        {
            Enter();
        }
        else
        {
            Exit();
        }
    }
    private void Exit()
    {
        print("The way is shut - He is coming!");
    }
    private void Enter()
    {
        print("Speak 'friend' and enter.");
    }
}
