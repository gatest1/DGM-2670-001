using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

    public string myName = "Taylor";
    public float height = 5.1f;
    public bool isCool = true;
    private int myAge;
    public int health = 100;
    private int maxHealthCount = 100;


    // Use this for initialization
    void Start () {
        print(myName);
        print(health);
	}
}
