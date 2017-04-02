using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShootingScript : MonoBehaviour {
	public Transform shotPivot;
	public GameObject shot;
	public float fireSpeed;

	private float nextShot;

	void Start() {
		nextShot = Time.time;		
	}

	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Fire1") && Time.time > nextShot) {
			Instantiate (shot, shotPivot.position, shot.transform.rotation);
		}
	}
}
