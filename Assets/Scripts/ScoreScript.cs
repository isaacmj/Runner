using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public Text text;
	public bool inIntro = true;
	private float playerScore = 0;
	
	// Update is called once per frame
	void Update () {
		if (!inIntro) {
			playerScore += Time.deltaTime;
			text.text = "Score: " + getDisplayableScore ();
		}
	}

	void OnDisable() {
		PlayerPrefs.SetInt ("Score", getDisplayableScore());
	}

	private int getDisplayableScore() {
		return (int)(playerScore * 100);
	}
}
