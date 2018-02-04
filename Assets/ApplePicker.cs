using UnityEngine;
using System.Collections;

public class ApplePicker : MonoBehaviour {
	[Header("Game Settings")]
	public GameObject basketPrefab;
	public int numberOfLives = 3;
	public float basketBottomY = -14f;
	public float basketSpacingY = 2f;




	// Use this for initialization
	void Start () {
		for (int i = 0; i < numberOfLives; i++) {
			GameObject tBasketGO = Instantiate<GameObject> (basketPrefab);

			Vector3 pos = Vector3.zero;

			pos.y = basketBottomY + (basketSpacingY * i);

			tBasketGO.transform.position = pos;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
