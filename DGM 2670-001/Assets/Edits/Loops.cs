using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

    public string[] animals = { "cat", "dog", "rabbit", "bear", "student", "fox"};
    // Use this for initialization
    void Start() {

        for (int i = 0; i < animals.Length; i++)
        {
            print("The " + animals[i] + "ate my taco.");
        }

        print("The cat ate my taco!");
        print("The dog ate my taco!");
        print("The rabbit ate my taco!");
        print("The bear ate my taco!");
        print("The student ate my taco!");
        print("The fox ate my taco!");
    }
}
	

