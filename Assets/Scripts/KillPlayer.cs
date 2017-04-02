using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
	private EndGameScript endGameScript;

	void Start() {
		endGameScript = (EndGameScript) FindObjectOfType (typeof(EndGameScript));
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Destroy (other.transform.root.gameObject);
			endGameScript.SignalGameOver ();
		}
	}
}
