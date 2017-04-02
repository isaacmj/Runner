using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour {
	private bool gameOver = false;
	public Text gameOverText;

	public void SignalGameOver() {
		gameOver = true;
		GetComponent<ScoreScript> ().active = false;
		gameOverText.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver && CrossPlatformInputManager.GetButtonDown ("Jump")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}
