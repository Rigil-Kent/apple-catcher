using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class HighScore : MonoBehaviour {
	static public int Score = 1000;


	void Awake() {

		// If the PlayerPrefs HighScore already esists, read it
		if (PlayerPrefs.HasKey("HighScore")) {
			Score = PlayerPrefs.GetInt ("HighScore");
		}

		// Assign the high score to HighScore
		PlayerPrefs.SetInt("HighScore", Score);
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Text gt = this.GetComponent<Text> ();
		gt.text = "High Score: " + Score;


		// Update the PlayerPrefs HighScore if necessary
		if (Score > PlayerPrefs.GetInt("HighScore")) {
			PlayerPrefs.SetInt ("HighScore", Score);
		}
	}
}
