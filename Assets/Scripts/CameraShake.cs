﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    private float shakeAmount = 0f;

    public Camera mainCam;
    public static CameraShake instance;

    private void Awake ()
	{
	    instance = this;
		if (mainCam == null) {
		    mainCam = Camera.main;
		}
    }

    public void Shake (float amount=0.04f, float length=0.5f) {
        shakeAmount = amount;
        InvokeRepeating("DoShake", 0, 0.01f);
        Invoke("StopShake", length);
	}

	private void DoShake() {
	    Vector3 camPos = mainCam.transform.position;
	    float offsetX = Random.value * shakeAmount * 2- shakeAmount;
		float offsetY = Random.value * shakeAmount * 2- shakeAmount;
		camPos.x += offsetX;
		camPos.y += offsetY;
		mainCam.transform.position = camPos;
	}

	private void StopShake() {
	    CancelInvoke("DoShake");
	    mainCam.transform.localPosition = new Vector3(0,0,-10f);
	}
}
