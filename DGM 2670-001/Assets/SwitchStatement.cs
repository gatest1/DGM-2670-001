using UnityEngine;
using System.Collections;

public class SwitchStatement : MonoBehaviour {

    public enum gameStates {Starting, Playing, Ending}
    public gameStates currentState = gameStates.Starting;
    void Start()
    {
        switch (currentState)
        {
            case gameStates.Starting:
                DoSomething("Starting");
                break;

            case gameStates.Playing:
                DoSomething("Playing");
                break;

            case gameStates.Ending:
                DoSomething("Ending");
                break;
        }
    }
   private void DoSomething(string v)
    {
        print("The game is " + v);
    }
}
