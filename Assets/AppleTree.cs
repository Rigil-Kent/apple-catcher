using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class AppleTree : MonoBehaviour {
	[Header("Set in Inspector")]

	// Prefab(s) for instantiating apples
	public GameObject applePrefab;
	public GameObject badApplePrefab;

	// Speed at which the AppleTree moves
	public float speed = 1f;

	// Distance where the AppleTree turns around
	public float LeftAndRightEdge =  Screen.width;

	// Chance that the AppleTree will change directions
	public float directionChangeChance = 0.1f;

	// Rate at which Apples will be instantiated
	public float secondsBetweenDrops = 1f;

	// Chance the Apple will be bad
	public float badAppleChance = 0.3f;


	// Global position variable;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
	    // Droping apples every second
		pos.y = 13;
		Invoke("DropApple", 2f);
	}
	
	// Update is called once per frame
	void Update () {
	    

	}



	void FixedUpdate() {

		MoveTree();
		ChangeDirection ();

	}



	void DropApple() {

		GameObject apple = Instantiate<GameObject> (applePrefab);
		GameObject badApple = Instantiate<GameObject> (badApplePrefab);

		if (Random.value < badAppleChance) {
			badApple.transform.position = transform.position;
			Invoke ("DropApple", 2f);
		} else {
			apple.transform.position = transform.position;
			Invoke ("DropApple", secondsBetweenDrops);
		}

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
		} else if (Random.value < directionChangeChance) {
			speed += -1;
		}

	}
}
