using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateMovement : MonoBehaviour {
	private Vector3 parentOffset;
	public float magnitude;
	public float frequency;

	// Use this for initialization
	void Start () {
		parentOffset = transform.parent.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 relativePosition = transform.parent.transform.position - parentOffset;
		float yPosition = relativePosition.y + Mathf.Sin (Time.time * frequency) * magnitude;
		transform.position = new Vector3 (relativePosition.x, yPosition, relativePosition.z);
	}
}
