using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Apple : MonoBehaviour {
	public static float bottomLimit = -20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomLimit) {
			Destroy (this.gameObject);
		}
	}
}
