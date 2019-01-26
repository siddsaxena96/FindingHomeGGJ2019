using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public GameObject player;
	public float smoothSpeed;
	public Vector3 offset;
	
	// Used to smoothly Lerp camera to the desired position
	void FixedUpdate () {
		if (player != null) {
			Vector3 desiredPosition = player.transform.position + offset;
			desiredPosition.z=-10f;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
	}
}
