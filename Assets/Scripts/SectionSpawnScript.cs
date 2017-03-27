using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionSpawnScript : MonoBehaviour {

	public Transform pivot;
	public GameObject[] obj;

	// Use this for initialization
	void Start () {
		Spawn ();		
	}

	void Spawn() {
		Instantiate (obj [Random.Range (0, obj.Length)], pivot.position, Quaternion.identity);
	}

	public void SignalSpawn() {
		Spawn ();
	}
}
