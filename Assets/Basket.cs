using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Basket : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MouseMovement ();
	}



	// move the basket with the mouse
	void MouseMovement() {
		// Get the current screen position of the mouse from Input
		Vector3 mousePos2D = Input.mousePosition;

		// The Camera's Z position sets how far to push the mouse into 3D
		mousePos2D.z = -Camera.main.transform.position.z;

		// Convert the point from 2D screen space into 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

		// Move the x position of the Basket to the x position of the mouse
		Vector3 pos = this.transform.position;

		pos.x = mousePos3D.x;

		this.transform.position = pos;
	}

}
