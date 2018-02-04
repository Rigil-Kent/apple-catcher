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
	public float LeftAndRightEdge = 10f;

	// Chance that the AppleTree will change directions
	public float directionChangeChance = 0.1f;

	// Rate at which Apples will be instantiated
	public float secondsBetweenDrops = 1f;



	// Use this for initialization
	void Start () {
	    // Droping apples every second
	}
	
	// Update is called once per frame
	void Update () {
	    
		MoveTree();

	}




	void MoveTree() {
		// Basic movement
		Vector3 pos = transform.position;

		pos.x += speed * Time.deltaTime;

		transform.position = pos;


		// Change Direction
		if (pos.x < -LeftAndRightEdge) {
			speed = Mathf.Abs (speed);
		} else if (pos.x > LeftAndRightEdge) {
			speed = -Mathf.Abs (speed);
		}
	}
}
