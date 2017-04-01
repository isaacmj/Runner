using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class StartGameScript : MonoBehaviour {
	public SectionSpawnScript spawnScript;
	public Text[] textsToHide;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Jump")) {
			spawnScript.inIntro = false;
			GetComponent<ScoreScript>().inIntro = false;
			foreach (Text textToHide in textsToHide) {
				textToHide.enabled = false;
			}
		}		
	}
}
