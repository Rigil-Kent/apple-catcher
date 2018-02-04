using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class AppleTree : MonoBehaviour {
	[Header("Set in Inspector")]

	// Prefab for instantiating apples
	public GameObject applePrefab;

	// Speed at which the AppleTree moves
	public float speed = 1f;

	// Distance where the AppleTree turns around
	public float LeftAndRightEdge =  Screen.width;

	// Chance that the AppleTree will change directions
	public float directionChangeChance = 0.1f;

	// Rate at which Apples will be instantiated
	public float secondsBetweenDrops = 1f;


	// Global position variable;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
	    // Droping apples every second
		pos.y = 13;
	}
	
	// Update is called once per frame
	void Update () {
	    
		MoveTree();
		ChangeDirection ();
	}




	void MoveTree() {
 
		pos.x += speed * Time.deltaTime;

		transform.position = pos;

	}



	void ChangeDirection() {
		
		if (pos.x < -LeftAndRightEdge) {
			speed = Mathf.Abs (speed);
		} else if (pos.x > LeftAndRightEdge) {
			speed = -Mathf.Abs (speed);
		}

	}
}
