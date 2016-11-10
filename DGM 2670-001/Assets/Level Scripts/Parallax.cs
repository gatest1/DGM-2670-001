using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {


	public float scrollSpeed = 0.03f;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;
		rend.material.mainTextureOffset = new Vector2 (offset, 0);
	}
}
