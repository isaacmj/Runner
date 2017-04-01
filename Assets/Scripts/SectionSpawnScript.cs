using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionSpawnScript : MonoBehaviour {

	public Transform pivot;
	public GameObject[] sections;
	public GameObject introSection;
	public bool inIntro = true;

	// Use this for initialization
	void Start () {
		Spawn ();		
	}

	void Spawn() {
		if (inIntro) {
			SpawnObject (introSection);
		} else {
			SpawnObject (sections [Random.Range (0, sections.Length)]);
		}
	}

	private void SpawnObject(GameObject objectToSpawn) {
		Instantiate (objectToSpawn, pivot.position, Quaternion.identity);
	}

	public void SignalSpawn() {
		Spawn ();
	}
}
