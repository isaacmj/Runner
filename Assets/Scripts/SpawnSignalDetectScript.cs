using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSignalDetectScript : MonoBehaviour {
	public GameObject spawner;
	private SectionSpawnScript spawnScript;

	void Start () {
		spawnScript = spawner.GetComponent<SectionSpawnScript> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Signaler") {
			spawnScript.SignalSpawn ();
			print ("Singal");
		}
	}
}
