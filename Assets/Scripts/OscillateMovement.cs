using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateMovement : MonoBehaviour {
	private float startPositionY;
	public float magnitude;
	public float frequency;

	// Use this for initialization
	void Start () {
		startPositionY = transform.position.y;		
	}
	
	// Update is called once per frame
	void Update () {
		float yPosition = startPositionY + Mathf.Sin (Time.time * frequency) * magnitude;
		transform.position = new Vector3 (transform.position.x, yPosition, transform.position.z);
	}
}
