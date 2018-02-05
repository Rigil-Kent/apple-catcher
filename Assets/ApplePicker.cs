using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;



public class ApplePicker : MonoBehaviour {
	[Header("Game Settings")]
	public GameObject basketPrefab;
	public int numberOfLives = 3;
	public float basketBottomY = -14f;
	public float basketSpacingY = 2f;
	public List<GameObject> basketList;



	// Use this for initialization
	void Start () {
		basketList = new List<GameObject> ();

		for (int i = 0; i < numberOfLives; i++) {
			GameObject tBasketGO = Instantiate<GameObject> (basketPrefab);

			Vector3 pos = Vector3.zero;

			pos.y = basketBottomY + (basketSpacingY * i);

			tBasketGO.transform.position = pos;

			basketList.Add (tBasketGO);
		}
	}
	
	// Update is called once per frame
	void Update () {
	

	}



	public void AppleDestroyed() {
		
		// Destroy all of the falling apples
		GameObject[] apples = GameObject.FindGameObjectsWithTag("Apple");
		GameObject[] badApples = GameObject.FindGameObjectsWithTag ("BadApple");

		foreach (GameObject go in apples) {
			Destroy (go);
		}


		foreach (GameObject ba in badApples) {
			Destroy (ba);
		}



		// Destroy one of the baskets
		// Get the index of the last Basket in basketList
		int basketIndex = basketList.Count - 1;

		// Get a reference to that Game Object
		GameObject tBasketGo = basketList[basketIndex];

		// Remove the Basket from the list and destroy the GameObject
		basketList.RemoveAt(basketIndex);
		Destroy (tBasketGo);


		// if there are no Basket left, restart the game
		if (basketList.Count == 0) {
			SceneManager.LoadScene ("_scene0");
		}
	}

}
