using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

    public string myName = "Taylor";
    public float speed = 5.5f;
    public bool isCool = true;
    private int myAge;
    public int health = 100;
    private int maxAmmoCoung = 100;


    // Use this for initialization
    void Start () {
        print(myName);
	}
	
	
}
